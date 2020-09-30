using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<TodoItem> GetAllItems();
        void AddTodo(string todoName);
        void ValueChanged(TodoItem changedItem);
        void DeleteItem(int id);
    }
}
