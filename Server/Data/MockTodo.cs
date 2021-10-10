using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Data
{
    public class MockTodo : ITodo
    {
        public List<Todo> todos = new List<Todo>
        {
            new Todo{id=21221, TodoText="vasketøj", Done=false},
            new Todo{id=21232221, TodoText="gøre rent", Done=false},
            new Todo{id=212434321, TodoText="rydde op", Done=false}
        };

        public IEnumerable<Todo> GetTodosItems()
        {
            return todos;
        }

        public IEnumerable<Todo> DeleteTodoItem(int id)
        {
            for (int i = 0; i < todos.Count; i++)
            {
                if (todos[i].id == id)
                {
                    todos.Remove(todos[i]);
                }
            }
            return todos;
        }

        public IEnumerable<Todo> AddTodoItem(Todo todoItem)
        {
            Todo testTodo = new Todo {
                        id=2020,
                        TodoText = "Støvsugning",
                        Done = false
                };

            todos.Add(todoItem);

            Console.WriteLine("Added to todos");
            return todos;
        }

        public IEnumerable<Todo> ChangeStateTodoItem(int id)
        {
            for (int i = 0; i < todos.Count; i++)
            {
                if (todos[i].id == id)
                {
                    todos[i].Done = !todos[i].Done;
                }
            }
            return todos;
        }



    }


}
