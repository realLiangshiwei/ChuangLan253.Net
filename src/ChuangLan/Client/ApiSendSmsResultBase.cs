using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ChuangLan.Client
{
    public class ApiSendSmsResultBase
    {

        /// <summary>
        /// 状态码（”返回0为成功，失败的返回值请查看“验证码通知和营销短信提交响应状态码“）
        /// </summary>
        public string Code { get; set; }

        public string ErrorMsg { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        public string MsgId { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        public string Time { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsSucceed()
        {
            return Code == "0";
        }
    }
}
