using ChuangLan.Configuration;

namespace ChuangLan
{
    public class ChuangLanManagerBase
    {
        protected const string VariableRegex = @"{\$([a-z]+)}";

        protected readonly ChuangLanOptions ChuangLanOptions;

        public ChuangLanManagerBase(ChuangLanOptions chuangLanOptions)
        {
            Check.CheckNull(chuangLanOptions, nameof(chuangLanOptions));
            Check.CheckNullOrWhiteSpace(chuangLanOptions.Account, nameof(chuangLanOptions.Account));
            Check.CheckNullOrWhiteSpace(chuangLanOptions.Password, nameof(chuangLanOptions.Password));
            Check.CheckNullOrWhiteSpace(chuangLanOptions.Host, nameof(chuangLanOptions.Host));
            Check.CheckNullOrWhiteSpace(chuangLanOptions.SignName, nameof(chuangLanOptions.SignName));
            ChuangLanOptions = chuangLanOptions;
        }

        public virtual string ApiUrl(string api)
        {
            return api.Replace("{host}", ChuangLanOptions.Host);
        }
    }
}
