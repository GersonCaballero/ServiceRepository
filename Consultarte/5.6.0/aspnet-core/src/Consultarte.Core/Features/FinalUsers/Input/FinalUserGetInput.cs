using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.FinalUsers.Input
{
    public class FinalUserGetInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
