using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebRestfulApiPermisos.Modelss.Models
{
    public class PermissionType
    {
        [Key]
        public int idPermissionType { get; set; }
        public string description { get; set; }
    }
}
