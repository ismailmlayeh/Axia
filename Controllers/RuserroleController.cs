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
    [Route("api/[controller]")]
    [ApiController]
    public class RuserroleController : ControllerBase
    {
       
        
            private readonly IRuserroleService RuserroleService;

            public RuserroleController(IRuserroleService ruserrole)
            {
                RuserroleService = ruserrole;
            }


        [HttpGet]
        [Route("GetRuserrole")]
   

        public IEnumerable<AspnetusersHasRolelist> GetRUserRolelists()
        {
            return RuserroleService.GetRUserRolelists();
        }

        [HttpPost]
        [Route("AddRUserRole")]
        

        public AspnetusersHasRolelist AddRuserrole(AspnetusersHasRolelist ruserrole)
        {
            
            return RuserroleService.AddRuserrole(ruserrole);
        }


        [HttpPut]
        [Route("UpdateRuserrole")]
        public AspnetusersHasRolelist UpdateRuserrole(AspnetusersHasRolelist ruserrole)
        {
            return RuserroleService.UpdateRuserrole(ruserrole);
        }


        [HttpDelete]
        [Route("DeleteRuserRole")]
        public AspnetusersHasRolelist DeleteRolelist(int id)
        {
            return RuserroleService.DeleteRuserrole(id);
        }





    }
}