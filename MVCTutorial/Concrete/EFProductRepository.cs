using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCTutorial.Abstract;
using MVCTutorial.Entities;

namespace MVCTutorial.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}