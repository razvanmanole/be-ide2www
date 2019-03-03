using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ide2www.MultiTenancy.Dto;

namespace ide2www.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

