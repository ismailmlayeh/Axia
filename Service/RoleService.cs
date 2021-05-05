using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class RoleService : IRoleService
    {
        workflowapiContext dbContext;

        public RoleService(workflowapiContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Rolelist> GetRolelists()
        {
            // throw new NotImplementedException();
            var Rolelist = dbContext.Rolelist.ToList();
            return Rolelist;
        }



        public Rolelist GetRolelistById(int id)
        {
            var rolelist = dbContext.Rolelist.FirstOrDefault(x => x.Id == id);


            return rolelist;


        }



        public Rolelist AddRolelist(Rolelist rolelist)
        {


            var checktitle = from d in dbContext.Rolelist
                             where d.Name== rolelist.Name

                             select d;



            if (checktitle.FirstOrDefault() == null && (rolelist != null))
               
            {
                dbContext.Rolelist.Add(rolelist);
                dbContext.SaveChanges();
                return rolelist;
            }
            return null;
        }


        public Rolelist UpdateRolelist(Rolelist rolelist)
        {

            dbContext.Entry(rolelist).State = EntityState.Modified;
            dbContext.SaveChanges();
            return rolelist;


        }


        public Rolelist DeleteRolelist(int id)
        {
            var rolelist = dbContext.Rolelist.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(rolelist).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return rolelist;


        }


    }
}

