using System.Threading.Tasks;
using Abp.Application.Services;
using MvC5.Authorization.Accounts.Dto;

namespace MvC5.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
