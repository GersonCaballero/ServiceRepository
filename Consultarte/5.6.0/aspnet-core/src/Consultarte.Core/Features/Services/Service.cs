using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Consultarte.Features.TypeServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.Services
{
    public class Service: Entity<long>, IFullAudited
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
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
