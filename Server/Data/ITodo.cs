using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;

namespace Server.Data
{
    public interface ITodo
    {
        IEnumerable<Todo> GetTodosItems();
    }
}
