using infoTechCollege.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace infoTechCollege.Tests.Models
{
    [TestClass]
    public class studentModelTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of a student
            clsStudent student = new clsStudent();
            //test to see if it works
            Assert.IsNotNull(student);
        }



        [TestMethod]
        public void firstname()
        {
            //creating an instance of a student
            clsStudent student = new clsStudent();
            //declaring test data
            string testdata = "Paul";
            //assigning data to the property
            student.firstname = testdata;
            //test to see if it works
            Assert.AreEqual(testdata, student.firstname);
        }

        [TestMethod]
        public void lastname()
        {
            //creating an instance of a student
            clsStudent student = new clsStudent();
            //declaring test data
            string testdata = "Banner";
            //assigning data to the property
            student.lastname = testdata;
            //test to see if it works
            Assert.AreEqual(testdata, student.lastname);
        }

        [TestMethod]
        public void email()
        {
            //creating an instance of a student
            clsStudent student = new clsStudent();
            //declaring test data
            string testdata = "paul@gmail.com";
            //assigning data to the property
            student.email = testdata;
            //test to see if it works
            Assert.AreEqual(testdata, student.email);
        }

        [TestMethod]
        public void town()
        {
            //creating an instance of a student
            clsStudent student = new clsStudent();
            //declaring test data
            string testdata = "Leicester";
            //assigning data to the property
            student.town = testdata;
            //test to see if it works
            Assert.AreEqual(testdata, student.town);
        }

        [TestMethod]
        public void dateOfbirth()
        {
            //creating an instance of a student
            clsStudent student = new clsStudent();
            //declaring test data
            string testdata = "12/02/1998";
            //assigning data to the property
            student.dateOfBirth = testdata;
            //test to see if it works
            Assert.AreEqual(testdata, student.dateOfBirth);
        }

        [TestMethod]
        public void phoneNumber()
        {
            //creating an instance of a student
            clsStudent student = new clsStudent();
            //declaring test data
            string testdata = "123456789014";
            //assigning data to the property
            student.phonemumber = testdata;
            //test to see if it works
            Assert.AreEqual(testdata, student.phonemumber);
        }
    }
}
