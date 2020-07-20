using Abp.Application.Services.Dto;

namespace Consultarte.Features.TypeServices.Input
{
    public class TypeServiceGetAllInput : IPagedResultRequest
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
