using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoTechCollege.Models
{
    public class Staff
    {
        public virtual int StaffId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
        public virtual string Mobile { get; set; }
    }
}