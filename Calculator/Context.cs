using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Context : DbContext
    {
        public DbSet<HesaplamaGeçmişi>geçmiş{ get; set; }
    }
}
