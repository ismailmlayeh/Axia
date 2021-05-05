using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class RuserroleService : IRuserroleService
    {
        workflowapiContext dbContext;

        public RuserroleService(workflowapiContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<AspnetusersHasRolelist> GetRUserRolelists()
        {
            // throw new NotImplementedException();
            var rur = dbContext.AspnetusersHasRolelist.ToList();
            return rur;
        }

        public AspnetusersHasRolelist AddRuserrole(AspnetusersHasRolelist ruserrole)
        {
            if (ruserrole != null)
            {
                dbContext.AspnetusersHasRolelist.Add(ruserrole);
                dbContext.SaveChanges();
                return ruserrole;
            }
            return null;
        }


        public AspnetusersHasRolelist UpdateRuserrole(AspnetusersHasRolelist ruserrole)
        {

            dbContext.Entry(ruserrole).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ruserrole;


        }

        public AspnetusersHasRolelist DeleteRuserrole(int id)
        {
            var ruserrole = dbContext.AspnetusersHasRolelist.FirstOrDefault(x => x.RolelistId == id);
            dbContext.Entry(ruserrole).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ruserrole;


        }


    }
}
