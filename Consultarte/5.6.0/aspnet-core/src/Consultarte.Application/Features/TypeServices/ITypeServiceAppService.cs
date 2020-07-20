using Abp.Application.Services;
using Consultarte.Features.TypeServices.Dto;
using Consultarte.Features.TypeServices.Input;

namespace Consultarte.Features.TypeServices
{
    public interface ITypeServiceAppService : IAsyncCrudAppService<TypeServiceDto, long, TypeServiceGetAllInput, TypeServiceCreateInput, TypeServiceUpdateInput, TypeServiceGetInput, TypeServiceDeleteInput>
    {
    }
}
