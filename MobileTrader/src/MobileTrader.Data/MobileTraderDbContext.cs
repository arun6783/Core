using System;
using Microsoft.EntityFrameworkCore;
using MobileTrader.Entity;

namespace MobileTrader.Data
{
    public class MobileTraderDbContext : DbContext
    {
        public MobileTraderDbContext( DbContextOptions<MobileTraderDbContext> options):base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }
        
    }
}
