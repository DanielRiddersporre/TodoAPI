using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTodo_Domain.Interfaces
{
    public interface ITodoListRepository
    {
        void AddTodoList();
        void UpdateTodoList(Guid id);
        void DeleteTodoList(Guid id);
    }
}
