using Abp.Application.Services.Dto;

namespace Consultarte.Features.Services.Input
{
    public class ServiceGetInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
