using Microsoft.EntityFrameworkCore;
using ParcelService.Domain.Entities;
using ParcelService.Infrastructure.ModelConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelService.Infrastructure
{
    public class EFAppContext : DbContext
    {

        public DbSet<Parcel> Parcels { get; set; }

        public EFAppContext(DbContextOptions<EFAppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ParcelConfiguration());
        }
    }
}
