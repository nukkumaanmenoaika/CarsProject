using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLists.TablesDB
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<NumberPathList> NumberPathList{ get; set; }
        public ApplicationContext() : base("DefaultConnection") { }
    }
}
