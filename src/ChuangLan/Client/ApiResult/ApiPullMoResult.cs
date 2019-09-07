using System.Collections.Generic;

namespace ChuangLan.Client.ApiResult
{
    public class ApiPullMoResult
    {
        /// <summary>
        /// 请求状态。0成功，其他状态为失败
        /// </summary>
        public int Ret { get; set; }

        /// <summary>
        /// 上行明细结果，没结果则返回空集合
        /// </summary>
        public List<ApiPullMoResultDetail> Result { get; set; }

        public bool IsSucceed()
        {
            return Ret == 0;
        }
    }

    public class ApiPullMoResultDetail
    {
        /// <summary>
        /// 运营商通道码
        /// </summary>
        public string DestCode { get; set; }

        /// <summary>
        /// 上行手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 上行时间，格式yyMMddHHmm，其中yy=年份的最后两位（00-99
        /// </summary>
        public string MoTime { get; set; }

        /// <summary>
        /// 平台通道码
        /// </summary>
        public string SpCode { get; set; }

        /// <summary>
        /// 上行内容
        /// </summary>
        public string MessageContent { get; set; }

    }
}
