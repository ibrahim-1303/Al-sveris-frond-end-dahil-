using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MvC5.MultiTenancy;

namespace MvC5.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}