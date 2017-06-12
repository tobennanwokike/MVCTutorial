using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCTutorial.Entities;
using System.Data.Entity;


namespace MVCTutorial.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}