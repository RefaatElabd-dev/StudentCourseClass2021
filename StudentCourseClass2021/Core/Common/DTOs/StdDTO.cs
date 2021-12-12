using System.Collections.Generic;

namespace Core.DSL
{
    public class StdDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<CourseDto> CourseDto { get; set; }
    }
}