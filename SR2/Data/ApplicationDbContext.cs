using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SR2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SR2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }
    }
}
