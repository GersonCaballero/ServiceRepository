using Abp.Application.Services;
using Abp.Domain.Repositories;
using Consultarte.Features.FinalUsers.Dto;
using Consultarte.Features.FinalUsers.Input;

namespace Consultarte.Features.FinalUsers
{
    public class FinalUserAppService : AsyncCrudAppService<FinalUser, FinalUserDto, long, FinalUserGetAllInput, FinalUserCreateInput, FinalUserUpdateInput, FinalUserGetInput, FinalUserDeleteInput>, IFinalUserAppService
    {
        public FinalUserAppService(IRepository<FinalUser, long> repository)
            : base(repository)
        {
        }
    }
}
