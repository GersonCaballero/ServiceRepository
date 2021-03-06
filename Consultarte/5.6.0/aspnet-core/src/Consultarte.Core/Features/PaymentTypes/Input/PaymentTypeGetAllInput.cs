﻿using Abp.Application.Services.Dto;

namespace Consultarte.Features.PaymentTypes.Input
{
    public class PaymentTypeGetAllInput : IPagedResultRequest
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
