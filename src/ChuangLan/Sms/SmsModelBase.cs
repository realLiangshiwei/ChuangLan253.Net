using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ChuangLan.Sms
{
    public class SmsModelBase
    {
        [JsonProperty]
        internal string Account { get; set; }

        [JsonProperty]
        internal string Password { get; set; }

        public string Msg { get; set; }

        /// <summary>
        /// 定时发送时间
        /// </summary>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// 状态报告
        /// </summary>
        public bool? Report { get; set; }

        /// <summary>
        /// 下发短信号码扩展码,建议1-3位(只支持传数字)
        /// </summary>
        public int? Extend { get; set; }

        /// <summary>
        /// 该条短信在您业务系统内的ID，如订单号或者短信发送记录流水号
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// 变量参数
        /// </summary>
        public string Params { get; set; }

    }
}
