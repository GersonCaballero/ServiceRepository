using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.Services.Dto
{
    [AutoMap(typeof(Service))]
    public class ServiceDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long? TypeServiceId { get; set; }
    }
}
