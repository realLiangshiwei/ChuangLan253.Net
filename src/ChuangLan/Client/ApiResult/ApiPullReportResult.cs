using System;
using System.Collections.Generic;
using System.Text;

namespace ChuangLan.Client.ApiResult
{
    public class ApiPullReportResult
    {
        /// <summary>
        /// 请求状态。0成功，其他状态为失败
        /// </summary>
        public int Ret { get; set; }

        /// <summary>
        /// 状态明细结果，没结果则返回空数组
        /// </summary>
        public List<ApiPullReportResultDetail> Result { get; set; }

        public bool IsSucceed()
        {
            return Ret == 0;
        }
    }

    public class ApiPullReportResultDetail
    {
        /// <summary>
        /// 用户在提交该短信时提交的uid参数，未提交则无该参数
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// 运营商返回的状态说明
        /// </summary>
        public string StatusDesc { get; set; }

        /// <summary>
        /// 253平台收到运营商回复状态报告的时间，格式yyMMddHHmmss
        /// </summary>
        public string NotifyTime { get; set; }

        /// <summary>
        /// 接收短信的手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        public string MsgId { get; set; }

        /// <summary>
        /// 状态更新时间，格式yyMMddHHmm，其中yy=年份的最后两位（00-99）
        /// </summary>
        public string ReportTime { get; set; }

        /// <summary>
        /// 运营商返回的状态（详细参考常见code.253.com常见状态报告状态码）
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 下发短信计费条数
        /// </summary>
        public string Length { get; set; }

    }
}
