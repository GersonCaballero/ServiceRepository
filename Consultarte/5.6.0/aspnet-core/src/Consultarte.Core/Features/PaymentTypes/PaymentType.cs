using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Consultarte.Features.ServiceProviderUsers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.PaymentTypes
{
    public class PaymentType: Entity<long>, IFullAudited
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long? ServiceProviderUserId { get; set; }
        public ServiceProviderUser ServiceProviderUser { get; set; }
        public bool IsActive { get; set; } = true;
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
