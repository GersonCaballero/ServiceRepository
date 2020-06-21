using System.Threading.Tasks;
using Abp.Application.Services;
using Consultarte.Sessions.Dto;

namespace Consultarte.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
