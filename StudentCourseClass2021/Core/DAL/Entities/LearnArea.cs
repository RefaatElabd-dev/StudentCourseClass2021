using Core.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DAL.Entities
{
    public class LearnArea: BaseEntity<int>
    {
        public string Code { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
