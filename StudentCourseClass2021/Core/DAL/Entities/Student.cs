using Core.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DAL.Entities
{
    public class Student : BaseEntity<int>
    {
        public string Name { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
