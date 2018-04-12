using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models
{
    [Table("Enrollment")]

    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Enrollment ID")]
        public int EnrollmentID { get; set; }

        [ForeignKey("associatedModule")]
        public int ModuleID { get; set; }
        public virtual Module associatedModule { get; set; }

        public virtual ICollection<Student> studentsEnrolled { get; set; }
    }
}