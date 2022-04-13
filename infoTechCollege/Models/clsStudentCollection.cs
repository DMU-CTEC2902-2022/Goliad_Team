using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace infoTechCollege.Models
{
    public class clsStudentCollection
    {
        List<clsStudent> studentList = new List<clsStudent>();
        private clsStudent ThisStudent;
        public clsStudent thisStudent { get => ThisStudent; set => ThisStudent = value; }

        public void addStudent()
        {
            studentList.Add(ThisStudent);
        }
    }
}