using Abp.Application.Services;
using Consultarte.Features.FinalUsers.Dto;
using Consultarte.Features.FinalUsers.Input;

namespace Consultarte.Features.FinalUsers
{
    public interface IFinalUserAppService : IAsyncCrudAppService<FinalUserDto, long, FinalUserGetAllInput, FinalUserCreateInput, FinalUserUpdateInput, FinalUserGetInput, FinalUserDeleteInput>
    {
    }
}
