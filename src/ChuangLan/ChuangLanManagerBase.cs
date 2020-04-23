using ChuangLan.Configuration;

namespace ChuangLan
{
    public class ChuangLanManagerBase
    {
        protected const string VariableRegex = @"{\$([a-z]+)}";

        protected readonly ChuangLanOptions ChuangLanOptions;

        public ChuangLanManagerBase(ChuangLanOptions chuangLanOptions)
        {
            ChuangLanOptions = chuangLanOptions;
            Check.CheckNull(chuangLanOptions, nameof(chuangLanOptions));
            Check.CheckNullOrWhiteSpace(ChuangLanOptions.Account, nameof(ChuangLanOptions.Account));
            Check.CheckNullOrWhiteSpace(ChuangLanOptions.Password, nameof(ChuangLanOptions.Password));
            Check.CheckNullOrWhiteSpace(ChuangLanOptions.Host, nameof(ChuangLanOptions.Host));
            Check.CheckNullOrWhiteSpace(ChuangLanOptions.SignName, nameof(ChuangLanOptions.SignName));
        }

        public virtual string ApiUrl(string api)
        {
            return api.Replace("{host}", ChuangLanOptions.Host);
        }
    }
}
