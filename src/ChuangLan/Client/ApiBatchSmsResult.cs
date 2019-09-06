using System;
using System.Collections.Generic;
using System.Text;

namespace ChuangLan.Client
{
    public class ApiBatchSmsResult : ApiSendSmsResultBase
    {
        public int FailNum { get; set; }

        public int SuccessNum { get; set; }
    }
}
