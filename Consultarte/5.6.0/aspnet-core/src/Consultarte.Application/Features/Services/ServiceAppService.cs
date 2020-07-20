using Abp.Application.Services;
using Consultarte.Features.Services.Input;
using Consultarte.Features.Services.Dto;
using Abp.Domain.Repositories;

namespace Consultarte.Features.Services
{
    public class ServiceAppService : AsyncCrudAppService<Service, ServiceDto, long, ServiceGetAllInput, ServiceCreateInput, ServiceUpdateInput, ServiceGetInput, ServiceDeleteInput>, IServiceAppService
    {
        public ServiceAppService(IRepository<Service, long> repository)
            : base(repository)
        {
        }
    }
}
