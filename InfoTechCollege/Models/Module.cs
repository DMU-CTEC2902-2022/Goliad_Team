using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoTechCollege.Models
{
    public class Module
    {
        public virtual int ModuleId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual string ModuleTitle { get; set; }
        public virtual string ModuleDescription { get; set; }
        public virtual string ModuleContent { get; set; }
    }
}