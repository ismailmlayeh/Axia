using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
   public interface IRuserroleService
    {
        IEnumerable<AspnetusersHasRolelist> GetRUserRolelists();



        AspnetusersHasRolelist AddRuserrole(AspnetusersHasRolelist ruserrole);

        AspnetusersHasRolelist UpdateRuserrole(AspnetusersHasRolelist ruserrole);

        AspnetusersHasRolelist DeleteRuserrole(int id);
        //}
    }
}
