using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "First Name")]
        public string Firstname { get => firstname; set => firstname = value; }

        [Display(Name = "Last Name")]
        public string Lastname { get => lastname; set => lastname = value; }

        [Display(Name = "Email")]
        public string Email { get => email; set => email = value; }

        [Display(Name = "Town")]
        public string Town { get => town; set => town = value; }

        [Display(Name = "Date of birth")]
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        [Display(Name = "Phone number")]
        public string Phonemumber { get => phonemumber; set => phonemumber = value; }
    }
}