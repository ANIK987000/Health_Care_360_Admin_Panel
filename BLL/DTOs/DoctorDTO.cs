using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DoctorDTO
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

        [Required(ErrorMessage = "*Qualification cannot be empty")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "*VisitingHours cannot be empty")]
        public string VisitingHours { get; set; }

        [Required(ErrorMessage = "*AppointmentFee cannot be empty")]
        public string AppointmentFee { get; set; }


    }
}
