using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoTechCollege.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }
        public virtual string CourseTitle { get; set; }
        public virtual string CourseDescription { get; set; }
    }
}