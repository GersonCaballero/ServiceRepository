using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.PaymentTypes.Dto
{
    [AutoMap(typeof(PaymentType))]
    public class PaymentTypeDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? ServiceProviderUserId { get; set; }
    }
}
