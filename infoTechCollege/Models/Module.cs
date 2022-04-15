using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace infoTechCollege.Models
{
    public class Module
    {
        public virtual int ModuleId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string Content { get; set; }
    }
}