using Abp.Application.Services;
using Consultarte.Features.PaymentTypes.Dto;
using Consultarte.Features.PaymentTypes.Input;

namespace Consultarte.Features.PaymentTypes
{
    public interface IPaymentTypeAppService : IAsyncCrudAppService<PaymentTypeDto, long, PaymentTypeGetAllInput, PaymentTypeCreateInput, PaymentTypeUpdateInput, PaymentTypeGetInput, PaymentTypeDeleteInput>
    {
    }
}
