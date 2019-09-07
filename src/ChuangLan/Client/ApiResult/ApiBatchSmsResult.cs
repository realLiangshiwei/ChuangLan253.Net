namespace ChuangLan.Client.ApiResult
{
    public class ApiBatchSmsResult : ApiSendSmsResultBase
    {
        public int FailNum { get; set; }

        public int SuccessNum { get; set; }
    }
}
