using System.Threading.Tasks;
using ChuangLan.Client;
using ChuangLan.Client.ApiRequest;
using ChuangLan.Client.ApiResult;

namespace ChuangLan
{

    public interface IChuangLanSmsManager
    {
        /// <summary>
        /// 单条发送
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        ApiSendSmsResultBase Send(SingleSms sms);

        /// <summary>
        /// 单条发送
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        Task<ApiSendSmsResultBase> SendAsync(SingleSms sms);

        /// <summary>
        /// 批量发送
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        ApiBatchSmsResult BatchSend(BatchSms sms);

        /// <summary>
        /// 批量发送
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        Task<ApiBatchSmsResult> BatchSendAsync(BatchSms sms);

        /// <summary>
        /// 余额查询
        /// </summary>
        /// <returns></returns>
        ApiBalanceResult Balance();

        /// <summary>
        /// 余额查询
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        Task<ApiBalanceResult> BalanceAsync();

        /// <summary>
        /// 拉取上行明细接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ApiPullMoResult PullMo(ApiPullMo input);

        /// <summary>
        /// 拉取上行明细接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ApiPullMoResult> PullMoAsync(ApiPullMo input);

        /// <summary>
        /// 拉取状态报告
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ApiPullReportResult PullReport(ApiPullReport input);

        /// <summary>
        /// 拉取状态报告
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ApiPullReportResult> PullReportAsync(ApiPullReport input);
    }

}
