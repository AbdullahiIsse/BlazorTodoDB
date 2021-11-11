using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdvancedTodo.DataAccess;
using AdvancedTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedTodo.Data
{
    public class SqliteTodoService : ITodoData
    {
        public async Task<IList<Todo>> GetTodos()
        {
            using TodoDBContext todoDbContext = new TodoDBContext();
            var list = await todoDbContext.Todos.ToListAsync();
            return  list;
        }

        public async Task AddTodo(Todo todo)
        {
            using TodoDBContext todoDbContext = new TodoDBContext();
            await todoDbContext.Todos.AddAsync(todo);
            await todoDbContext.SaveChangesAsync();
        }

        public async Task RemoveTodo(int todoId)
        {
            using TodoDBContext todoDbContext = new TodoDBContext();
            Todo firstAsync = await todoDbContext.Todos.FirstAsync(todo => todo.TodoId == todoId);
            todoDbContext.Remove(firstAsync);
            await todoDbContext.SaveChangesAsync();
        }

        public async Task Update(Todo todo)
        {
            using TodoDBContext todoDbContext = new TodoDBContext();
            todoDbContext.Update(todo);
            await todoDbContext.SaveChangesAsync();
        }

        public async Task<Todo> Get(int id)
        {
            
            using TodoDBContext todoDbContext = new TodoDBContext();
            Todo firstAsync = await todoDbContext.Todos.FirstAsync(todo => todo.TodoId == id);


            return firstAsync;
            
        }
    }
}