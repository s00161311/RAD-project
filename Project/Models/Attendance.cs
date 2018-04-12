using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models
{
    [Table("Attendance")]

    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Attendance ID")]
        public int AttendanceID { get; set; }
        public DateTime AttDate { get; set; }
        public virtual Delivery ForDelivery { get; set; }
       // public virtual ICollection<Project> attendees { get; set; }

    }
}