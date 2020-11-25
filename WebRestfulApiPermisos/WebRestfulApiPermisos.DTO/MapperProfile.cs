using AutoMapper;
using System;
using WebRestfulApiPermisos.DTO.Models;
using WebRestfulApiPermisos.Modelss.Models;

namespace WebRestfulApiPermisos.DTO
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<PermissionDTO, Permission>().ReverseMap();
        }
    }
}
