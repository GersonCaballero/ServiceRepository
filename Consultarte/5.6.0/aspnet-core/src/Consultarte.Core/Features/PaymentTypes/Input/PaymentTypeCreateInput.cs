using Abp.AutoMapper;

namespace Consultarte.Features.PaymentTypes.Input
{
    [AutoMap(typeof(PaymentType))]
    public class PaymentTypeCreateInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? ServiceProviderUserId { get; set; }
        public bool IsActive { get; set; }
    }
}
