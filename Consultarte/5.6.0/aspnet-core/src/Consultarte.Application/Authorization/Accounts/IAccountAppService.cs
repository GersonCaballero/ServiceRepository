using System.Threading.Tasks;
using Abp.Application.Services;
using Consultarte.Authorization.Accounts.Dto;

namespace Consultarte.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
