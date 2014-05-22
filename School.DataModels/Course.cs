using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.DataModels
{
    public class Course
    {
        public int Id { get; set; }

        public int CourseNumber { get; set; }
        public string CourseName { get; set; }

        public virtual Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
