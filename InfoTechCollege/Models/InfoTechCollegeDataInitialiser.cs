using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using InfoTechCollege.Data;

namespace InfoTechCollege.Models
{
    public class InfoTechCollegeDataInitialiser : DropCreateDatabaseAlways<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {
            InfoTechCollege.Models.Course cos1 = new InfoTechCollege.Models.Course();
            cos1.CourseId = 1;
            cos1.CourseTitle = "Computer Science";
            cos1.CourseDescription = "";
            context.Courses.Add(cos1);

            InfoTechCollege.Models.Course cos2 = new InfoTechCollege.Models.Course();
            cos2.CourseId = 2;
            cos2.CourseTitle = "Software Engineering";
            cos2.CourseDescription = "";
            context.Courses.Add(cos2);

            InfoTechCollege.Models.Course cos3 = new InfoTechCollege.Models.Course();
            cos3.CourseId = 3;
            cos3.CourseTitle = "Cyber Security";
            cos3.CourseDescription = "";
            context.Courses.Add(cos3);

            //..............................................................

            InfoTechCollege.Models.Module mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 1903;
            mod1.CourseId = 1;
            mod1.ModuleTitle = "Scala Programming";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 1920;
            mod1.CourseId = 1;
            mod1.ModuleTitle = "Database Management";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 2905;
            mod1.CourseId = 1;
            mod1.ModuleTitle = "Object Orientated Programming (Java)";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 2910;
            mod1.CourseId = 1;
            mod1.ModuleTitle = "Database Management";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3911;
            mod1.CourseId = 1;
            mod1.ModuleTitle = "Mobile Application";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 1920;
            mod1.CourseId = 1;
            mod1.ModuleTitle = "Computer Ethics and Privacy";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 1920;
            mod1.CourseId = 1;
            mod1.ModuleTitle = "Development Project";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3906;
            mod1.CourseId = 2;
            mod1.ModuleTitle = "Interaction Design";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3410;
            mod1.CourseId = 2;
            mod1.ModuleTitle = "Web Application Penetration Testing";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3406;
            mod1.CourseId = 2;
            mod1.ModuleTitle = "Fuzzy Logic & Knowledge Based Systems";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3613;
            mod1.CourseId = 2;
            mod1.ModuleTitle = "Data Mining";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3614;
            mod1.CourseId = 2;
            mod1.ModuleTitle = "Big Data & Business Models";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3611;
            mod1.CourseId = 2;
            mod1.ModuleTitle = "Computer Ethics and Privacy";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 34511;
            mod1.CourseId = 2;
            mod1.ModuleTitle = "Development Project";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3901;
            mod1.CourseId = 3;
            mod1.ModuleTitle = "C Programming";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3902;
            mod1.CourseId = 3;
            mod1.ModuleTitle = "Computer Law and Cyber Security Management";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3903;
            mod1.CourseId = 3;
            mod1.ModuleTitle = "Linux Security";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3904;
            mod1.CourseId = 3;
            mod1.ModuleTitle = "Cyber Threat Intelligence and Incident Response";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3905;
            mod1.CourseId = 3;
            mod1.ModuleTitle = "Malware Analysis";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3611;
            mod1.CourseId = 3;
            mod1.ModuleTitle = "Computer Ethics and Privacy";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            mod1 = new InfoTechCollege.Models.Module();
            mod1.ModuleId = 3451;
            mod1.CourseId = 3;
            mod1.ModuleTitle = "Development Project";
            mod1.ModuleDescription = "";
            mod1.ModuleContent = "";
            context.Modules.Add(mod1);

            //....................................................

            InfoTechCollege.Models.Staff sta1 = new InfoTechCollege.Models.Staff();
            sta1.StaffId = 1;
            sta1.CourseId = 1;
            sta1.FirstName = "William";
            sta1.LastName = "Chamberlin";
            sta1.Email = "william.chamberlin@informationtec.col.uk";
            sta1.Address = "";
            sta1.Mobile = "";
            context.Staffs.Add(sta1);

            InfoTechCollege.Models.Staff sta2 = new InfoTechCollege.Models.Staff();
            sta2 = new InfoTechCollege.Models.Staff();
            sta2.StaffId = 2;
            sta2.CourseId = 2;
            sta2.FirstName = "Jenny";
            sta2.LastName = "Francis";
            sta2.Email = "jenny.francis@informationtec.col.uk";
            sta2.Address = "";
            sta2.Mobile = "";
            context.Staffs.Add(sta2);

            InfoTechCollege.Models.Staff sta3 = new InfoTechCollege.Models.Staff();
            sta3 = new InfoTechCollege.Models.Staff();
            sta3.StaffId = 3;
            sta3.CourseId = 3;
            sta3.FirstName = "Thomas";
            sta3.LastName = "Woods";
            sta3.Email = "thomas.woods@informationtec.col.uk";
            sta3.Address = "";
            sta3.Mobile = "";
            context.Staffs.Add(sta3);

            base.Seed(context);
        }

    }
}