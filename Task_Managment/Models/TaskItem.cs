using System.ComponentModel.DataAnnotations;

namespace Task_Managment.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime DeuDate { get; set; }

        [Required]
        public required string Priority { get; set; }

        public User? User { get; set; }

        public int? AssingeId { get; set; }
    }
}
 