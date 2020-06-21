using Abp.Application.Services;
using Consultarte.MultiTenancy.Dto;

namespace Consultarte.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

