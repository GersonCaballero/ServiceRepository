using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.PaymentTypes.Input
{
    public class PaymentTypeGetInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
