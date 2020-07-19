using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.TypeServices.Input
{
    
    public class TypeServiceGetInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
