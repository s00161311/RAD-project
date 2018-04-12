using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models
{
    [Table("Student")]

    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student ID")]
        public int StudentID { get; set; }

        [Display(Name = "Student First Name")]
        public string StudentFName { get; set; }

        [Display(Name = "Student Last Name")]
        public string StudentLName { get; set; }

        [ForeignKey("associatedModule")]
        public int ModuleID { get; set; }
        public virtual Module associatedModule { get; set; }

        [ForeignKey("associatedAttendance")]
        public int AttendanceID { get; set; }
        public virtual Module associatedAttendance { get; set; }

    }
}