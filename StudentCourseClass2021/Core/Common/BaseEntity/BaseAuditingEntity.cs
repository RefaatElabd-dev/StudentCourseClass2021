using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Common.BaseEntity
{
    public class BaseAuditingEntity<T> : BaseEntity<T>
    {
        public DateTime CreationTime { get; set; }
        public string Createdby { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Updatedby { get; set; }
        public DateTime DeletionTime { get; set; }
        public string Deleteddby { get; set; }
    }
}
