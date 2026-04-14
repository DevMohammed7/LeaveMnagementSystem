using System.ComponentModel.DataAnnotations;

namespace LeaveMnagementSystem.web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;

        [Display(Name = "NO. Days")]

        public int NumberOfDays { get; set; }
    }
}
