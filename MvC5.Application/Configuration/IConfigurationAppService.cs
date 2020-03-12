using System.Threading.Tasks;
using Abp.Application.Services;
using MvC5.Configuration.Dto;

namespace MvC5.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}