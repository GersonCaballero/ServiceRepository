using Abp.Application.Services.Dto;

namespace Consultarte.Features.PaymentTypes.Input
{
    public class PaymentTypeDeleteInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
