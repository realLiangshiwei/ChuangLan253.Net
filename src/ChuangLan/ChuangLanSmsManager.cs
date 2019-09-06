using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ChuangLan.Client;
using ChuangLan.Configuration;
using ChuangLan.Sms;
using Newtonsoft.Json;

namespace ChuangLan
{
    public class ChuangLanSmsManager : IChuangLanSmsManager
    {
        private const string SimpleSmsUrl = "http://smssh1.253.com/msg/send/json";

        private const string VariableSmsUrl = "http://smssh1.253.com/msg/variable/json";

        private const string VariableRegex = @"{\$([a-z]+)}";

        private readonly ChuangLanOptions _chuangLanOptions;

        public ChuangLanSmsManager(ChuangLanOptions chuangLanOptions)
        {
            Check.CheckNull(chuangLanOptions, nameof(chuangLanOptions));
            Check.CheckNullOrWhiteSpace(chuangLanOptions.Account, nameof(chuangLanOptions.Account));
            Check.CheckNullOrWhiteSpace(chuangLanOptions.Password, nameof(chuangLanOptions.Password));
            Check.CheckNullOrWhiteSpace(chuangLanOptions.SignName, nameof(chuangLanOptions.SignName));
            _chuangLanOptions = chuangLanOptions;
        }

        public async Task<ApiSendSmsResultBase> Send(SingleSms sms)
        {
            string url;
            CheckSmsModel(sms);

            if (Regex.IsMatch(sms.Msg, VariableRegex))
            {
                url = VariableSmsUrl;
                Check.CheckNullOrWhiteSpace(sms.Params, nameof(sms.Params));
            }
            else
            {
                url = SimpleSmsUrl;
                Check.CheckNullOrWhiteSpace(sms.Phone, nameof(sms.Phone));
            }

            var qc = JsonConvert.SerializeObject(sms);
            return await ApiHttpClient.PostAsync<ApiSendSmsResultBase>(url, JsonConvert.SerializeObject(sms));

        }

        public async Task<ApiBatchSmsResult> BatchSend(BatchSms sms)
        {
            CheckSmsModel(sms);
            string url;
            if (Regex.IsMatch(sms.Msg, VariableRegex))
            {
                url = VariableSmsUrl;
                Check.CheckNullOrWhiteSpace(sms.Params, nameof(sms.Params));
            }
            else
            {
                url = SimpleSmsUrl;
                Check.CheckNull(sms.Phone, nameof(sms.Phone));
                foreach (var phone in sms.Phone)
                {
                    Check.CheckNullOrWhiteSpace(phone, nameof(phone));
                }
            }
            return await ApiHttpClient.PostAsync<ApiBatchSmsResult>(url, JsonConvert.SerializeObject(sms));
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
