using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.ServiceProviderUsers.Input
{
    public class ServiceProviderUserDeleteInput : IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
