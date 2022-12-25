using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NoticeBoardDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Title cannot be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "*Description cannot be empty ")]
        public string Description { get; set; }

        [Required(ErrorMessage = "*Start Date cannot be empty")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "*End Date cannot be empty")]
        public DateTime EndDate { get; set; }
    }
}
