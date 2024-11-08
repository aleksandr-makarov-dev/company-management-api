using System.ComponentModel.DataAnnotations;

namespace CompanyManagement.API.Modules.Management.Models
{
    public class TaskRequest
    {
        [MaxLength(150)]
        public string Title { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        public DateTime? ScheduledAt { get; set; } = null;
    }
}
