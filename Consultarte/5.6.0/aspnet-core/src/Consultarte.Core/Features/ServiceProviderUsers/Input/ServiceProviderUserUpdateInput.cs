using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Consultarte.Features.ServiceProviderUsers.Input
{
    [AutoMap(typeof(ServiceProviderUser))]
    public class ServiceProviderUserUpdateInput : IEntityDto<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
        public string Municipality { get; set; }
        public string LocationGPS { get; set; }
        public string CellphoneNumber { get; set; }
        public int qualification { get; set; }
        public long? TypeServiceId { get; set; }
    }
}
