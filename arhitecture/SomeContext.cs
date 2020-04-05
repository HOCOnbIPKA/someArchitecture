using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using core;

namespace infrastructure
{
    class SomeContext : DbContext
    {
        public SomeContext()
            : base("name=SomeContextConnectionString")
        {
            var a = Database.Connection.ConnectionString;
        }
        public DbSet<Element> Elements { get; set; }
    }
}
