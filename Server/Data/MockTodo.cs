using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data
{
    public class MockTodo
    {
        //Mockdata
        public List<Todo> todos = new List<Todo>
        {
            new Todo{Id=21221, TodoText="Vasketøj", Done=false},
            new Todo{Id=21232221, TodoText="Gøre rent", Done=false},
            new Todo{Id=212434321, TodoText="Rydde op", Done=false}
        };

        public IEnumerable<Todo> GetTodosItems()
        {
            return todos;
        }

        public IEnumerable<Todo> DeleteTodoItem(int Id)
        {
            for (int i = 0; i < todos.Count; i++)
            {
                if (todos[i].Id == Id)
                {
                    todos.Remove(todos[i]);
                }
            }
            return todos;
        }

        public IEnumerable<Todo> AddTodoItem(Todo todoItem)
        {
            todos.Add(todoItem);
            return todos;
        }

        public IEnumerable<Todo> ChangeStateTodoItem(int Id)
        {
            for (int i = 0; i < todos.Count; i++)
            {
                if (todos[i].Id == Id)
                {
                    todos[i].Done = !todos[i].Done;
                }
            }
            return todos;
        }



    }


}
