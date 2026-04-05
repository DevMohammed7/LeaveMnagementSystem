using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveMnagementSystem.web.Data
{
    // The Entity
    public class LeaveType
    {
        public int Id { get; set; } // Primary key for the LeaveType entity
        [MaxLength(150)]
        public string Name { get; set; } // Name of the leave type (e.g., "Vacation", "Sick Leave")
        public int NumberOfDays { get; set; } 
    }
}
