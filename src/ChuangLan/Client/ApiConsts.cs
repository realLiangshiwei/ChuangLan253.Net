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
    }
}
