using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebRestfulApiPermisos.Modelss.Models
{
    public class Permission
    {
        [Key]
        public int? idPermission { get; set; }
        public string employerName { get; set; }
        public string employerLastName { get; set; }
        public DateTime permissionDate { get; set; }
        public int idPermissionType { get; set; }


        public virtual PermissionType PermissionType { get; set; }

    }
}
