using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.TypeServices.Input
{
    [AutoMap(typeof(TypeService))]
    class TypeServiceUpdateInput : IEntityDto<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
