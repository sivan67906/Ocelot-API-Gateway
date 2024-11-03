using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductService.Model;

namespace ProductService.Data
{
    public class ProductServiceContext : DbContext
    {
        public ProductServiceContext (DbContextOptions<ProductServiceContext> options)
            : base(options)
        {
        }

        public DbSet<ProductService.Model.Product> Product { get; set; } = default!;
    }
}
