using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models
{
    [Table("Module")]

    public class Module
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Module ID")]
        public int ModuleID { get; set; }

        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual ICollection<Student> studentsInModule { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}