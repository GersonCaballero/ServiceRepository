using Abp.Application.Services;
using Abp.Domain.Repositories;
using Consultarte.Features.PaymentTypes.Dto;
using Consultarte.Features.PaymentTypes.Input;

namespace Consultarte.Features.PaymentTypes
{
    public class PaymentTypeAppService : AsyncCrudAppService<PaymentType, PaymentTypeDto, long, PaymentTypeGetAllInput, PaymentTypeCreateInput, PaymentTypeUpdateInput, PaymentTypeGetInput, PaymentTypeDeleteInput>, IPaymentTypeAppService
    {
        public PaymentTypeAppService(IRepository<PaymentType, long> repository)
            : base(repository)
        {
        }
    }
}
