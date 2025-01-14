using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinancialCrm.Models;

namespace MyFinancialCrm.Context
{
    public class AppDbContext :DbContext
    {
        public DbSet<Users> Users { get; set; }

        public AppDbContext() : base("FinancialCrmDbEntities")
        {
        }
    }
}
