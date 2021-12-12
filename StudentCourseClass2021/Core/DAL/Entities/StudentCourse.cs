using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DAL.Entities
{
    public class StudentCourse
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
