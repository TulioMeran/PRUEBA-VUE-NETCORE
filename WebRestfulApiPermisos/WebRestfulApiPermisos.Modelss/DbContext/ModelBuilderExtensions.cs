using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebRestfulApiPermisos.Modelss.Models;

namespace WebRestfulApiPermisos.Modelss.DbContext
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermissionType>().HasData(
                new PermissionType()
                {
                    idPermissionType = 1,
                    description = "SOPORT"
                },
                 new PermissionType()
                 {
                     idPermissionType = 2,
                     description = "ASISTENT"
                 }
                ); 
        }
    }
}
