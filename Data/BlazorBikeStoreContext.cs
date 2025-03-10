using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorBikeStore.Models;

namespace BlazorBikeStore.Data
{
    public class BlazorBikeStoreContext : DbContext
    {
        public BlazorBikeStoreContext (DbContextOptions<BlazorBikeStoreContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorBikeStore.Models.Bike> Bike { get; set; } = default!;
    }
}
