using DataAccess.Products;
using DataAccess.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DomainTables
{
    public class AxessoriesDb : DbContext
    {
        public AxessoriesDb() : base("AxessoriesContext") { }

        #region User

        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }

        #endregion

        #region Products

        public DbSet<Phones> Phones { get; set; }
        public DbSet<Televisions> Televisions { get; set; }
        public DbSet<Watches> Watches { get; set; }
        public DbSet<Accessories> Accessories { get; set; }
        public DbSet<Audios> Audios { get; set; }

        #endregion
    }
}
