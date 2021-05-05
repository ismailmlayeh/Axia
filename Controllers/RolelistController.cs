using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RolelistController : ControllerBase
    {
        private readonly IRoleService roleService;

        public RolelistController(IRoleService rolelist)
        {
            roleService = rolelist;
        }


        [HttpGet]
       // [Route("Getrole")]
        

        public IEnumerable<Rolelist> GetRolelists()
        {
            return roleService.GetRolelists();
        }

        [HttpGet("{id}")]
        //[Route("GetRoleById")]
        public Rolelist GetRolelistById(int id)
        {
            return roleService.GetRolelistById(id);
        }


        [HttpPost]
        //[Route("AddRole")]
        

        public Rolelist AddRolelist(Rolelist rolelist)
        {
            return roleService.AddRolelist(rolelist);
        }

        [HttpPut("{id}")]
        //[Route("UpdateRole")]
        public Rolelist UpdateRolelist(int id ,Rolelist rolelist)
        {
            rolelist.Id = id;
            return roleService.UpdateRolelist(rolelist);
        }

        [HttpDelete("{id}")]
        //[Route("DeleteRole")]
        public Rolelist DeleteRolelist(int id)
        {
            return roleService.DeleteRolelist(id);
        }


    }
}

