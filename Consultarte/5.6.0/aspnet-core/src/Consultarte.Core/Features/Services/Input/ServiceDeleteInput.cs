using Abp.Application.Services.Dto;

namespace Consultarte.Features.Services.Input
{
    public class ServiceDeleteInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
