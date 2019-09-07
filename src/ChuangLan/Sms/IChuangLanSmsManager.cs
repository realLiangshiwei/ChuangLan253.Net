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
        Task<ApiSendSmsResultBase> Send(SingleSms sms);

        /// <summary>
        /// 批量发送
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        Task<ApiBatchSmsResult> BatchSend(BatchSms sms);

        /// <summary>
        /// 余额查询
        /// </summary>
        /// <returns></returns>
        Task<ApiBalanceResult> Balance();

        /// <summary>
        /// 拉取上行明细接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ApiPullMoResult> PullMo(ApiPullMo input);

        /// <summary>
        /// 拉取状态报告
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ApiPullReportResult> PullReport(ApiPullReport input);
    }

}
