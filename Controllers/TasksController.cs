using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        [HttpGet]
        public IActionResult Tasks()
        {
         
            var tasks = new string[] { "Task1", "Task2", "Task3", "Task4" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var sometingWentWrong = true;
            if (sometingWentWrong)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
