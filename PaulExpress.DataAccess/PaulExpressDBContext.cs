using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PaulExpress.Domain.Entities;

namespace PaulExpress.DataAccess
{
    public class PaulExpressDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<OrderLineSupplement> OrderLineSupplements { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Sandwich> Sandwiches { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<Supplement> Supplements { get; set; }

        public DbSet<Shop> Shop { get; set; }
        public PaulExpressDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
