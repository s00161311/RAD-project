using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models
{
    [Table("Lecturer")]

    public class Lecturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Lecturer ID")]
        public int LecturerID { get; set; }

        [Display(Name = "Lecturer Name")]
        public string LecturerName { get; set; }

       

    }
}