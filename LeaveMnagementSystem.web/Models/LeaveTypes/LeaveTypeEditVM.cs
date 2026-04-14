using System.ComponentModel.DataAnnotations;

namespace LeaveMnagementSystem.web.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {
        [Required]
        [Length(4, 150, ErrorMessage = "You have violated the length requirement")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 90)]
        [Display(Name = "NO. Days")] 
        public int NumberOfDays { get; set; }
    }
}
