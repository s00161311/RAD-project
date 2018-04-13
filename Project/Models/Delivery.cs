using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models
{
    [Table("Delivery")]

    public class Delivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Delivery ID")]
        public int DeliveryID { get; set; }

        [ForeignKey( "associatedModule")]
        public int ModuleID { get; set; }
        public virtual Module associatedModule { get; set; }

        [ForeignKey("associatedLecturer")]
        public int LecturerID { get; set; }
        public virtual Lecturer associatedLecturer { get; set; }

        [ForeignKey("associatedRoom")]
        public int RoomID { get; set; }
        public virtual Room associatedRoom { get; set; }

        [ForeignKey("associatedAttendance")]
        public int AttendanceID { get; set; }
        public virtual Attendance associatedAttendance { get; set; }


        
    }
}