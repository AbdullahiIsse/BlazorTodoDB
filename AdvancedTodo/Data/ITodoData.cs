using System.Collections.Generic;
using System.Threading.Tasks;
using AdvancedTodo.Models;

namespace AdvancedTodo.Data
{
    public interface ITodoData
    {


        Task<IList<Todo>> GetTodos();
        Task AddTodo(Todo todo);
        Task RemoveTodo(int todoId);

        Task Update(Todo todo);

        Task<Todo> Get(int id);






    }
}