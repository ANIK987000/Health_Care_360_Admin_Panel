using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Name cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Email cannot be empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Password cannot be empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*Phone number cannot be empty")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "*Address cannot be empty")]
        public string Address { get; set; }

        [Required(ErrorMessage = "*Date of birth cannot be empty")]
        public string Dob { get; set; }

        [Required(ErrorMessage = "*BloodGroup cannot be empty")]
        public string BloodGroup { get; set; }

        [Required(ErrorMessage = "*Disease cannot be empty")]
        public string Disease { get; set; }

    }
}
