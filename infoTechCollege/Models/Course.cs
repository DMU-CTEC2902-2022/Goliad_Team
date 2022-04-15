using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace infoTechCollege.Models
{
    public class Course
    { 
        public virtual int CourseId { get; set; }
        public virtual int ModuleId { get; set; }
        public virtual string Title { get; set; }
    }
}