using Abp.Application.Services.Dto;

namespace Consultarte.Features.TypeServices.Input
{
    public class TypeServiceDeleteInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
