using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MvC5.Roles.Dto;
using MvC5.Users.Dto;

namespace MvC5.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}