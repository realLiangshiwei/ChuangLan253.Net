using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ChuangLan.Client.ApiRequest
{
    public class ApiSubAccountAdd
    {
        /// <summary>
        /// 用户名，由商务提供
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 时间戳（10位）
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// 需要设置子账号的扣款类型，格式为 产品id:扣款类型，比如 49:1 代表行业验证码主帐号计费，49:0代表示子账号独立计费；该子账号同时创建验证码短信和会员营销短信产品示例：'product_permit_pay'='49:0,52:0'
        /// </summary>
        public string Product_Permit_Pay { get; set; }

        /// <summary>
        /// 用途分类 如：0 其它,1 web，2 app
        /// </summary>
        public int Use_Type { get; set; }

        /// <summary>
        /// 子账号用途（1-50字符）
        /// </summary>
        public string Use_desc { get; set; }

        /// <summary>
        /// 姓名（<50字符）
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 部门或分部名称（<=50个字）
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 职位（<=8个字）
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 要开通的子账号名称（6-20字符）
        /// </summary>
        public string Account_Username { get; set; }

        /// <summary>
        /// 要开通的子账号密码（6-16字符）
        /// </summary>
        public string Account_password { get; set; }
    }
}
