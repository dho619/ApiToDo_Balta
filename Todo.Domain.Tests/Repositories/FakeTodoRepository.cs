using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {
        }

        public TodoItem GetById(Guid id, string user)
        {
            return new TodoItem("Titulo aqui", "kabum.cabum", DateTime.Now);
        }

        public void Update(TodoItem todo)
        {
        }
    }
}