using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MvC5.MultiTenancy.Dto;

namespace MvC5.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
