# 创蓝短信API文档

.NET Standard 2.0 框架

* 面向接口,对依赖注入友好
* 同步,异步方法

## 入门

安装nuget包

`Install-Package ChuangLanSms`

### 简单使用

```csharp
var smsManager = new ChuangLanSmsManager(new ChuangLanOptions()
{
    Account = "Account",
    Password = "Password",
    SignName = "【SignName】"
} );

await smsManager.SendAsync(new SingleSms()
{
    Msg = "验证码{$var}，您正在注册成为新用户，感谢您的支持！",
    Params = "18611223344,123456"
});

```

### 依赖注入

```csharp
//依赖注入
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

var res = await sms.SendAsync(new SingleSms()
{
    Msg = "验证码{$var}，您正在注册成为新用户，感谢您的支持！",
    Params = "18611223344,123456"
});
Console.WriteLine("Hello World!");
```

## 短信Api

```csharp
public interface IChuangLanSmsManager
{
    /// <summary>
    /// 单条发送
    /// </summary>
    /// <param name="sms"></param>
    /// <returns></returns>
    ApiSendSmsResultBase Send(SingleSms sms);

    /// <summary>
    /// 单条发送
    /// </summary>
    /// <param name="sms"></param>
    /// <returns></returns>
    Task<ApiSendSmsResultBase> SendAsync(SingleSms sms);

    /// <summary>
    /// 批量发送
    /// </summary>
    /// <param name="sms"></param>
    /// <returns></returns>
    ApiBatchSmsResult BatchSend(BatchSms sms);

    /// <summary>
    /// 批量发送
    /// </summary>
    /// <param name="sms"></param>
    /// <returns></returns>
    Task<ApiBatchSmsResult> BatchSendAsync(BatchSms sms);

    /// <summary>
    /// 余额查询
    /// </summary>
    /// <returns></returns>
    ApiBalanceResult Balance();

    /// <summary>
    /// 余额查询
    /// </summary>
    /// <returns></returns>
    /// <returns></returns>
    Task<ApiBalanceResult> BalanceAsync();

    /// <summary>
    /// 拉取上行明细接口
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    ApiPullMoResult PullMo(ApiPullMo input);

    /// <summary>
    /// 拉取上行明细接口
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<ApiPullMoResult> PullMoAsync(ApiPullMo input);

    /// <summary>
    /// 拉取状态报告
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    ApiPullReportResult PullReport(ApiPullReport input);

    /// <summary>
    /// 拉取状态报告
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<ApiPullReportResult> PullReportAsync(ApiPullReport input);
}
```

具体参数介绍可参考[创蓝文档](https://zz.253.com/api_doc/) 