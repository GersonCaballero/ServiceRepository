using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Consultarte.Features.TypeServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.ServiceProviderUsers
{
    public class ServiceProviderUser: Entity<long>, IFullAudited
    {
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
        public bool IsActive { get; set; } = true;
        public long? TypeServiceId { get; set; }
        public TypeService TypeService { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
