using ChuangLan.Sms;

namespace ChuangLan.Client.ApiRequest
{
    public class BatchSms : SmsModelBase
    {
        public string[] Phone { get; set; }
    }
}
