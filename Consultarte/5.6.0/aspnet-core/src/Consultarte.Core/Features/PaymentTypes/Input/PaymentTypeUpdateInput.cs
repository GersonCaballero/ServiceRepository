using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.PaymentTypes.Input
{
    [AutoMap(typeof(PaymentType))]
    public class PaymentTypeUpdateInput : IEntityDto<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? ServiceProviderUserId { get; set; }
    }
}
