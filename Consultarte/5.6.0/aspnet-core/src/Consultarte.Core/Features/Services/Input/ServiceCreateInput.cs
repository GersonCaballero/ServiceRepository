using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.Services.Input
{
    [AutoMap(typeof(Service))]
    public class ServiceCreateInout
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long? TypeServiceId { get; set; }
    }
}
