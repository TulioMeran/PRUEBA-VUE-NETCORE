using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebRestfulApiPermisos.DTO.Models;
using WebRestfulApiPermisos.Modelss.Models;

namespace WebRestfulApiPermisos.Api.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public PermissionController(IPermissionRepository permissionRepository, IMapper mapper)
        {
            this._permissionRepository = permissionRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route("api/permission/all")]
        public IActionResult GetEveryPermission()
        {
            return Ok(_mapper.Map<IEnumerable< PermissionDTO>>( _permissionRepository.GetAllPermission()));
        }

        [HttpGet]
        [Route("api/permission/type/all")]
        public IActionResult GetEveryPermissionType()
        {
            return Ok(_permissionRepository.GetAllTypePermission());
        }

        [HttpPost]
        [Route("api/permission/erase")]
        public IActionResult ErasePermission(Permission permission)
        {
            try
            {
                int id = Convert.ToInt16( permission.idPermission);
                return Ok(_permissionRepository.ErasePermission(id));

            } catch(Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError.ToString(), ex.Message);
            }
           
        }

        [HttpPost]
        [Route("api/permission/save")]
        public IActionResult SavePermission(Permission permission)
        {
            try
            {

                int op = 0;

                if (string.IsNullOrEmpty(permission.idPermission.ToString()))
                {
                    op = 1;
                } else
                {
                    op = 2;

                }

                return Ok(_permissionRepository.SavePermission(permission, op));

            } catch(Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError.ToString(), ex.Message);
            }
            
        }



    }
}