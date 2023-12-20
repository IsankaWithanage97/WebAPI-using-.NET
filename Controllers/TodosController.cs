using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("{id?}")]
        public IActionResult getTodos(int? id)
        {

            var myTodods = _todoService.AllTodos();

            if (id is  null) 
            {
                return Ok(myTodods);
            }

            myTodods = myTodods.Where(x => x.Id == id).ToList();

            return Ok(myTodods);
        }

        //get Todods


        
    }
}
