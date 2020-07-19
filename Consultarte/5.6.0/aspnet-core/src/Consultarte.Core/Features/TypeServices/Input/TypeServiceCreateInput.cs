using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.TypeServices.Input
{
    [AutoMap(typeof(TypeService))]
    public class TypeServiceCreateInput
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
