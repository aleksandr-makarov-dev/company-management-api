using System.ComponentModel.DataAnnotations;

namespace CompanyManagement.API.Modules.Management.Entities
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime ScheduledAt { get; set; }
    }
}
