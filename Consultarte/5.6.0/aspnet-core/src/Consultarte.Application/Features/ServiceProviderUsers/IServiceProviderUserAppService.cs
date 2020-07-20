using Abp.Application.Services;
using Consultarte.Features.ServiceProviderUsers.Dto;
using Consultarte.Features.ServiceProviderUsers.Input;

namespace Consultarte.Features.ServiceProviderUsers
{
    public interface IServiceProviderUserAppService : IAsyncCrudAppService<ServiceProviderUserDto, long, ServiceProviderUserGetAllInput, ServiceProviderUserCreateInput, ServiceProviderUserUpdateInput, ServiceProviderUserGetInput, ServiceProviderUserDeleteInput>
    {
    }
}
