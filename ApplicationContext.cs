using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Extensions.Logging;

namespace IEnumerableEQueryable
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connectionString;
        private readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(configure =>
            configure.AddConsole());

        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_loggerFactory);
            optionsBuilder.UseSqlite(_connectionString);
        }
    }
}