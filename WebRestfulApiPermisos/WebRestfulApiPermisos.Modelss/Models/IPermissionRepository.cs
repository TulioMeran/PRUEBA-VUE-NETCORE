using System;
using System.Collections.Generic;
using System.Text;

namespace WebRestfulApiPermisos.Modelss.Models
{
    public interface IPermissionRepository
    {
        IEnumerable<Permission> GetAllPermission();
        IEnumerable<PermissionType> GetAllTypePermission();
        Permission SavePermission(Permission permission, int op);
        Permission ErasePermission(int id);
    }
}
