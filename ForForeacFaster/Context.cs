using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForForeacFaster
{
    internal class Context:DbContext
    {
        public Context() : base("EntityConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Orders> orders { get; set; }
    }
}
