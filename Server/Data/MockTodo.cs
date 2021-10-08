using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data
{
    public class MockTodo : ITodo
    {
        public IEnumerable<Todo> GetTodosItems()
        {
            var todos = new List<Todo>
            {
                new Todo{id=21221, TodoText="vasketøj", Done=false},
                new Todo{id=21232221, TodoText="gøre rent", Done=false},
                new Todo{id=212434321, TodoText="rydde op", Done=false}
            };

        return todos;
        }
    }
}
