using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Context_En : DbContext
    {
        public Context_En(DbContextOptions<Context_En> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(Context_En).Assembly);
        }
        
        public DbSet<TestTable4> testTables { get; set; }
        public DbSet<TestTable2> testTables2 { get; set; }
        public DbSet<TestTable3> testTables3 { get; set; }
    }
}
