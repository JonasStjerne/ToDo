using Microsoft.AspNetCore.Mvc;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Data;

namespace Server.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly MockTodo _repository = new MockTodo();
        [HttpGet]
        public ActionResult <IEnumerable<Todo>> GetAllTodos()
        {
            return Ok(_repository.GetTodosItems()); 
        }

    }
}
