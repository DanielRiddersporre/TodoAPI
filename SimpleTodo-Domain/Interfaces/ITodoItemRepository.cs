using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTodo_Domain.Interfaces
{
    public interface ITodoItemRepository
    {
        void Add(TodoItem item);
        void Update(TodoItem item);
        void Delete(TodoItem item);
    }
}
