using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.TypeServices.Dto
{
    [AutoMap(typeof(TypeService))]
    public class TypeServiceDto : EntityDto<long>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
