using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MvC5.Configuration.Dto;

namespace MvC5.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MvC5AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
