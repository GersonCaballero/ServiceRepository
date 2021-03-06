﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.Services.Input
{
    [AutoMap(typeof(Service))]
    public class ServiceUpdateInput : IEntityDto<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long? TypeServiceId { get; set; }
        public bool IsActive { get; set; }
    }
}
