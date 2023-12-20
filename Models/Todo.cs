namespace WebAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime Due { get; set;}

        public TodoStatus status { get; set; } // New, Inprogress, Completed
    }
}
