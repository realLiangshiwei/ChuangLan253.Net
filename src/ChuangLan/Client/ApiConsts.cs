using System;
using System.Collections.Generic;
using System.Text;

namespace ChuangLan.Client
{
    internal class ApiConsts
    {
        public const string SimpleSmsUrl = "https://{host}/msg/send/json";

        public const string VariableSmsUrl = "https://{host}/msg/variable/json";

        public const string BalanceUrl = "https://{host}/msg/balance/json";

        public const string PullMoUrl = "http://{host}/msg/pull/mo";

        public const string PullReportUrl = "http://{host}/msg/pull/report";

        public const string SubAccountAddUrl = "https://zz.253.com/apis/subaccount/add";

        public const string SubAccountActiveUrl = "https://zz.253.com/apis/subaccount/active";

        public const string SubAccountAllotUrl = "https://zz.253.com/apis/subaccount/allot";

        public const string SubAccountGetUrl = "https://zz.253.com/apis/subaccount/get";

        public const string SubAccountGetIdsUrl = "https://zz.253.com/apis/subaccount/getids";

        public const string SubAccountGetStatusUrl = "https://zz.253.com/apis/subaccount/getstatus";
    }
}
