using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebRestfulApiPermisos.Modelss.Models
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly AppDbContext _context;

        public PermissionRepository(AppDbContext context)
        {
            this._context = context;
        }

        public Permission ErasePermission(int id)
        {
            var permit = _context.Permissions.Find(id);
            _context.Permissions.Remove(permit);
            _context.SaveChanges();

            return permit;
        }

        public IEnumerable<Permission> GetAllPermission()
        {
            return this._context.Permissions.Include(p => p.PermissionType).ToList();
        }

        public IEnumerable<PermissionType> GetAllTypePermission()
        {
            return this._context.TypePermissions.ToList();
        }


        public Permission SavePermission(Permission permission, int op)
        {
            if(op == (int)operation.neww)
            {
                _context.Permissions.Add(permission);
                _context.SaveChanges();

                return permission;

            } else if (op == (int)operation.update)
            {
                var updated = _context.Permissions.Attach(permission);

                updated.State = EntityState.Modified;

                _context.SaveChanges();

                return permission;

            }

            return new Permission();
        }
    }
}
