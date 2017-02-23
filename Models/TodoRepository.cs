using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApi.Models
{
    public class TodoRepository : ITodoRepository
    {
        private readonly WebApplication.Data.ApplicationDbContext _context;

        public TodoRepository(WebApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }
    }
}