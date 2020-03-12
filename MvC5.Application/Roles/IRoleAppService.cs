using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MvC5.Roles.Dto;

namespace MvC5.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
