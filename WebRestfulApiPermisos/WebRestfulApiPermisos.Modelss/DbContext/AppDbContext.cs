using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebRestfulApiPermisos.Modelss.DbContext;
using WebRestfulApiPermisos.Modelss.Models;

namespace WebRestfulApiPermisos.Modelss
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> TypePermissions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
        }

    }
}
