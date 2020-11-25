using System;
using System.Collections.Generic;
using System.Text;

namespace WebRestfulApiPermisos.DTO.Models
{
    public class PermissionDTO
    {
        public int idPermission { get; set; }
        public string employerName { get; set; }
        public string employerLastName { get; set; }
        public DateTime permissionDate { get; set; }
        public int idPermissionType { get; set; }


        public virtual PermissionTypeDTO PermissionType { get; set; }
    }
}
