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
        private static MockTodo _repository = new MockTodo();
        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAllTodos()
        {
            return Ok(_repository.GetTodosItems());
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Todo>> DeleteTodoById(int id)
        {
            return Ok(_repository.DeleteTodoItem(id));
        }

        [HttpPost]
        public ActionResult<IEnumerable<Todo>> AddTodo(Todo todo)
        {
            return Ok(_repository.AddTodoItem(todo));
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Todo>> ChangeTodoStateById(int id)
        {
            return Ok(_repository.ChangeStateTodoItem(id));
        }

    }
}
