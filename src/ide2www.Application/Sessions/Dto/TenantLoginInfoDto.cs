using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ide2www.MultiTenancy;

namespace ide2www.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
