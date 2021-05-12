using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Model;
using Microsoft.Data.Sqlite;

namespace TodoList.Data
{
    public class AppPostgreSqlContext : DbContext
    {
        public AppPostgreSqlContext(DbContextOptions<AppPostgreSqlContext> options) : base(options)
        {

        }
        public DbSet<Todo> Todos { get; set; }
    }
}
