using System;
using System.Collections.Generic;
using System.Text;

namespace WebRestfulApiPermisos.Modelss.Models
{
    public class PermissionFilter
    {
        public int? idPermission { get; set; }
        public string employerName { get; set; }
        public string employerLastName { get; set; }
        public string permissionDate { get; set; }
        public int idPermissionType { get; set; }
    }
}
