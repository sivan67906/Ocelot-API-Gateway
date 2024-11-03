using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderService.Model;

namespace OrderService.Data
{
    public class OrderServiceContext : DbContext
    {
        public OrderServiceContext (DbContextOptions<OrderServiceContext> options)
            : base(options)
        {
        }

        public DbSet<OrderService.Model.Order> Order { get; set; } = default!;
    }
}
