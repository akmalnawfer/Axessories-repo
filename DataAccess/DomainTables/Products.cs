using DataAccess.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DomainTables
{
    public class Products : DbContext
    {
        public Products() : base("AxessoriesContext") { }

        public DbSet<Phones> Phones { get; set; }
    }
}
