using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consultarte.Features.TypeServices
{
    public class TypeService: Entity<long>, IFullAudited
    {
        public string Name { get; set; }
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
