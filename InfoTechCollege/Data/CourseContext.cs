using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InfoTechCollege.Data
{
    public class CourseContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CourseContext() : base("name=CourseContext")
        {
        }

        public System.Data.Entity.DbSet<InfoTechCollege.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<InfoTechCollege.Models.Module> Modules { get; set; }

        public System.Data.Entity.DbSet<InfoTechCollege.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<InfoTechCollege.Models.Staff> Staffs { get; set; }
    }
}
