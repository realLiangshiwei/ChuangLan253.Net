using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ChuangLan.Client;
using ChuangLan.Client.ApiRequest;
using ChuangLan.Client.ApiResult;
using ChuangLan.Configuration;
using Newtonsoft.Json;

namespace ChuangLan.Sms
{
    public class ChuangLanSmsManager : ChuangLanManagerBase, IChuangLanSmsManager
    {

        private readonly ChuangLanOptions _chuangLanOptions;

        public ChuangLanSmsManager(ChuangLanOptions chuangLanOptions)
            : base(chuangLanOptions)
        {
        }

        public async Task<ApiSendSmsResultBase> Send(SingleSms sms)
        {
            string url;
            CheckSmsModel(sms);

            if (Regex.IsMatch(sms.Msg, VariableRegex))
            {
                url = ApiUrl(ApiConsts.VariableSmsUrl);
                Check.CheckNullOrWhiteSpace(sms.Params, nameof(sms.Params));
            }
            else
            {
                url = ApiUrl(ApiConsts.SimpleSmsUrl);
                Check.CheckNullOrWhiteSpace(sms.Phone, nameof(sms.Phone));
            }

            return await ApiHttpClient.PostAsync<ApiSendSmsResultBase>(url, JsonConvert.SerializeObject(sms));

        }

        public async Task<ApiBatchSmsResult> BatchSend(BatchSms sms)
        {
            CheckSmsModel(sms);
            string url;
            if (Regex.IsMatch(sms.Msg, VariableRegex))
            {
                url = ApiUrl(ApiConsts.VariableSmsUrl);
                Check.CheckNullOrWhiteSpace(sms.Params, nameof(sms.Params));
            }
            else
            {
                url = ApiUrl(ApiConsts.SimpleSmsUrl);
                Check.CheckNull(sms.Phone, nameof(sms.Phone));
                foreach (var phone in sms.Phone)
                {
                    Check.CheckNullOrWhiteSpace(phone, nameof(phone));
                }
            }
            return await ApiHttpClient.PostAsync<ApiBatchSmsResult>(url, JsonConvert.SerializeObject(sms));
        }

        public async Task<ApiBalanceResult> Balance()
        {
            return await ApiHttpClient.PostAsync<ApiBalanceResult>(ApiUrl(ApiConsts.BalanceUrl), JsonConvert.SerializeObject(new { _chuangLanOptions.Account, _chuangLanOptions.Password }));
        }

        public async Task<ApiPullMoResult> PullMo(ApiPullMo input)
        {
            input.Account = _chuangLanOptions.Account;
            input.Password = _chuangLanOptions.Password;
            return await ApiHttpClient.PostAsync<ApiPullMoResult>(ApiUrl(ApiConsts.BalanceUrl), JsonConvert.SerializeObject(input));
        }

        public async Task<ApiPullReportResult> PullReport(ApiPullReport input)
        {
            input.Account = _chuangLanOptions.Account;
            input.Password = _chuangLanOptions.Password;
            return await ApiHttpClient.PostAsync<ApiPullReportResult>(ApiUrl(ApiConsts.BalanceUrl), JsonConvert.SerializeObject(input));
        }

        private void CheckSmsModel(SmsModelBase sms)
        {
            Check.CheckNull(sms, nameof(sms));
            Check.CheckNullOrWhiteSpace(sms.Msg, nameof(sms.Msg));
            if (!sms.Report.HasValue)
            {
                sms.Report = _chuangLanOptions.Report;
            }

            sms.Msg = _chuangLanOptions.SignName + sms.Msg;
            sms.Account = _chuangLanOptions.Account;
            sms.Password = _chuangLanOptions.Password;
        }


    }
}
