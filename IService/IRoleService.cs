using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
   public interface IRoleService
    {
        IEnumerable<Rolelist> GetRolelists();

        Rolelist GetRolelistById(int id);
        Rolelist AddRolelist(Rolelist rolelist);

        Rolelist UpdateRolelist(Rolelist rolelist);

        Rolelist DeleteRolelist(int id);

    }
}
