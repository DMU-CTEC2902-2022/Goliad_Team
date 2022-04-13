using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace infoTechCollege.Models
{
    public class clsStudent
    {
        private string firstname;
        private string lastname;
        private string email;
        private string town;
        private string dateOfBirth;
        private string phonemumber;

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Town { get => town; set => town = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Phonemumber { get => phonemumber; set => phonemumber = value; }
    }
}