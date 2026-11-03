namespace TaskManagementAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public int Priority { get; set; } // 1- low, 2- medium, 3- high
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        //Foreign Key
        public int UserId { get; set; }

        //Navigation Property

        public User User { get; set; } = null;
    }
}
