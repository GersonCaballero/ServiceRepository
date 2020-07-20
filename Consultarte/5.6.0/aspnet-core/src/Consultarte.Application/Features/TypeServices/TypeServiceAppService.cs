using Abp.Application.Services;
using Abp.Domain.Repositories;
using Consultarte.Features.TypeServices.Dto;
using Consultarte.Features.TypeServices.Input;

namespace Consultarte.Features.TypeServices
{
    public class TypeServiceAppService : AsyncCrudAppService<TypeService, TypeServiceDto, long, TypeServiceGetAllInput, TypeServiceCreateInput, TypeServiceUpdateInput, TypeServiceGetInput, TypeServiceDeleteInput>, ITypeServiceAppService
    {
        public TypeServiceAppService(IRepository<TypeService, long> repository)
            : base(repository)
        {
        }
    }
}
