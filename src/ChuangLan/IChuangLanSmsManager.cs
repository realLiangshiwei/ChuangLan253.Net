using System.Threading.Tasks;
using ChuangLan.Client;
using ChuangLan.Sms;

namespace ChuangLan
{

    public interface IChuangLanSmsManager
    {
        Task<ApiSendSmsResultBase> Send(SingleSms sms);

        Task<ApiBatchSmsResult> BatchSend(BatchSms sms);
    }

}
