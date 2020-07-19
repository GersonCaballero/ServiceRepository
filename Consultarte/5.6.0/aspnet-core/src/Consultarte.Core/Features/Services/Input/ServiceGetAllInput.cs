using Abp.Application.Services.Dto;

namespace Consultarte.Features.Services.Input
{
    public class ServiceGetAllInput : IPagedResultRequest
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
