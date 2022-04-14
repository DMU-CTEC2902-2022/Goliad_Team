using infoTechCollege.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace infoTechCollege.Tests.Models
{
    [TestClass]
    public class studentCollectionModelTest
    {
        [TestMethod]
        public void instanceOK()
        {
            clsStudentCollection AllStudents = new clsStudentCollection();
            //test to see if it works
            Assert.IsNotNull(AllStudents);
        }

        [TestMethod]
        public void ThisStudentOK()
        {
            clsStudentCollection AllStudents = new clsStudentCollection();
            //create a random student
            clsStudent testStudent = new clsStudent();
            //set properties
            testStudent.Firstname = "Paul";
            testStudent.Lastname = "Baner";
            testStudent.Email = "Paul@gmail.com";
            testStudent.Phonemumber = "1234567897412";
            testStudent.DateOfBirth = "12/02/1998";
            //assign the dtata to the property
            AllStudents.thisStudent = testStudent;
            //test to see if they are the same
            Assert.AreEqual(AllStudents.thisStudent, testStudent);
        }

        [TestMethod]
        public void AddmethodOK()
        {
            clsStudentCollection AllStudents = new clsStudentCollection();
            //create a random student
            clsStudent testStudent = new clsStudent();
            //set properties
            testStudent.Firstname = "Paul";
            testStudent.Lastname = "Baner";
            testStudent.Email = "Paul@gmail.com";
            testStudent.Phonemumber = "1234567897412";
            testStudent.DateOfBirth = "12/02/1998";
            //set ThisSTudent
            AllStudents.thisStudent = testStudent;
            //add the record
            AllStudents.addStudent();
            //test to see if they are the same
            Assert.AreEqual(AllStudents.thisStudent, testStudent);
        }
    }
}
