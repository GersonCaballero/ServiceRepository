﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.ServiceProviderUsers.Input
{
    public class ServiceProviderUserGetAllInput : IPagedResultRequest
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
