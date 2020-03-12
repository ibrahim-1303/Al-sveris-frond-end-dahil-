using System.Threading.Tasks;
using Abp.Application.Services;
using MvC5.Sessions.Dto;

namespace MvC5.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
