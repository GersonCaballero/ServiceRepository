using Abp.Application.Services.Dto;

namespace Consultarte.Features.ServiceProviderUsers.Input
{
    public class ServiceProviderUserGetInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
