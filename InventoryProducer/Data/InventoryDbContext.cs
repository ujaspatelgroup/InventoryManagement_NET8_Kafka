using InventoryProducer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryProducer.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) { }
        public DbSet<InventoryRequest> InventoryUpdates { get; set; }
    }
}
