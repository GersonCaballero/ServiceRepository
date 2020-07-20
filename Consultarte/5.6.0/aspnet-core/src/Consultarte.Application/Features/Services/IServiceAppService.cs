using Abp.Application.Services;
using Consultarte.Features.Services.Dto;
using Consultarte.Features.Services.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.Services
{
    public interface IServiceAppService : IAsyncCrudAppService<ServiceDto, long, ServiceGetAllInput, ServiceCreateInput, ServiceUpdateInput, ServiceGetInput, ServiceDeleteInput>
    {
    }
}
