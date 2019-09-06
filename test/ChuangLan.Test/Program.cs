using System;
using System.Threading.Tasks;
using ChuangLan.Configuration;
using ChuangLan.Sms;
using Microsoft.Extensions.DependencyInjection;

namespace ChuangLan.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddSingleton(new ChuangLanOptions()
                {
                    Account = "Account",
                    Password = "Password",
                    SignName = "【SignName】"
                })
                .AddTransient<IChuangLanSmsManager, ChuangLanSmsManager>()
                .BuildServiceProvider();


            var sms = services.GetService<IChuangLanSmsManager>();

            var res = await sms.Send(new SingleSms()
            {
                Msg = "验证码{$var}，您正在注册成为新用户，感谢您的支持！",
                Params = "18611223344,123456"
            });
            Console.WriteLine("Hello World!");
        }
    }
}
