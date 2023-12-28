using System.ComponentModel.DataAnnotations;

namespace PSITS_Attendance.Models
{
    public class AdminData
    {
        [Key]
        public int admin_id { get; set; }
        [Required]
        public string admin_name { get; set; }
        public string admin_email_address { get; set; } 
        public string admin_password { get; set; }
        public string admin_status { get; set; }
    }
}
