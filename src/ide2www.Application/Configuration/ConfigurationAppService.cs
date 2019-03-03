using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ide2www.Configuration.Dto;

namespace ide2www.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ide2wwwAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
