using Abp.Application.Services;
using Abp.Domain.Repositories;
using Consultarte.Features.ServiceProviderUsers.Dto;
using Consultarte.Features.ServiceProviderUsers.Input;

namespace Consultarte.Features.ServiceProviderUsers
{
    public class ServiceProviderUserAppService : AsyncCrudAppService<ServiceProviderUser, ServiceProviderUserDto, long, ServiceProviderUserGetAllInput, ServiceProviderUserCreateInput, ServiceProviderUserUpdateInput, ServiceProviderUserGetInput, ServiceProviderUserDeleteInput>, IServiceProviderUserAppService
    {
        public ServiceProviderUserAppService(IRepository<ServiceProviderUser, long> repository)
            : base(repository)
        {
        }
    }
}
