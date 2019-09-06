# 创蓝253短信 .NET sdk

## 入门

安装nuget包

`Install-Package ChuangLanSms`

配置创蓝平台账号密码与配置`SmsManager`,建议使用依赖注入

```csharp
var services = new ServiceCollection()
    .AddSingleton(new ChuangLanOptions()
    {
        Account = "Account",
        Password = "Password",
        SignName = "【SignName】"
    })
    .AddTransient<IChuangLanSmsManager, ChuangLanSmsManager>()
    .BuildServiceProvider();
```

发送短信

```csharp
var sms = services.GetService<IChuangLanSmsManager>();

var res = await sms.Send(new SingleSms()
{
    Msg = "验证码{$var}，您正在注册成为新用户，感谢您的支持！",
    Params = "18611223344,123456"
});
Console.WriteLine("Hello World!");
```

具体参数介绍可参考[创蓝文档](https://zz.253.com/api_doc/) 