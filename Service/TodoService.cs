using WebAPI.Models;

namespace WebAPI.Service
{
    public class TodoService
    {
        public List<Todo> AllTodos()
        {
            var todods = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for School",
                Description = "Get some text books for school",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                status = TodoStatus.Completed
            };
            todods.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get Vegetables",
                Description = "Getvegetables for week",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                status = TodoStatus.New
            };
            todods.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plants",
                Description = "Water all the plants quickly",
                CreatedDate = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                status = TodoStatus.Inprogress
            };
            todods.Add(todo3);

            return todods;

        }
    }
}
