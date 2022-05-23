using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using xnes_hw.Models;

namespace xnes_hw
{
    public class XnesDbContext: DbContext
    {
      
        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}