using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApi.Models
{
    public class TodoRepository : ITodoRepository
    {
        private static readonly List<TodoItem> _context = new List<TodoItem>();

        static TodoRepository()
        {
            _context = new List<TodoItem>();
            _context.Add(new TodoItem{ Name="Item1"});
            _context.Add(new TodoItem{ Name="Item2"});
            _context.Add(new TodoItem{ Name="Item3"});
        }

        public void Add(TodoItem item)
        {
            _context.Add(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _context.ToList();
        }

        public TodoItem Find(long key)
        {
            return _context.FirstOrDefault(t => t.Key == key);
        }

        public void Remove(long key)
        {
            var entity = _context.First(t => t.Key == key);
            _context.Remove(entity);            
        }

        public void Update(TodoItem item)
        {
            this.Remove(item.Key);
            this.Add(item);
        }
    }
}