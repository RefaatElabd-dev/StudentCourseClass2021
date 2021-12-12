using Core.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DAL.Entities
{
    public class Course : BaseEntity<int>
    {
        public string Name { get; set; }
        public virtual ICollection<StudentCourse> CourseStudents { get; set; }
        public int LearnAreaID { get; set; }
        public virtual LearnArea LearnArea { get; set; }

    }
}
