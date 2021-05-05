using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class ConditionService : IConditionService
    {
        workflowapiContext dbContext;

        public ConditionService(workflowapiContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Condition> GetCondition()
        {
           var C = dbContext.Condition.ToList();
            return C; 
        }

        public Condition GetConditionById(int id)
        {
            var c = dbContext.Condition.FirstOrDefault(x => x.Idcondition == id);


            return c;


        }

        public Condition AddCondition (Condition con)


        {

            var checktitle = from d in dbContext.Condition
                             where d.ConditionTitle == con.ConditionTitle

                             select d;



            if (checktitle.FirstOrDefault() == null && (con != null))
            {
                dbContext.Condition.Add(con);
                dbContext.SaveChanges();
                return con;
            }
            return null;
        }

        public Condition UpdateCondition(Condition con)
        {
            dbContext.Entry(con).State = EntityState.Modified;
            dbContext.SaveChanges();
            return con;
        }

        public Condition DeleteCondition(int id)
        {
            var dcon = dbContext.Condition.FirstOrDefault(x => x.Idcondition == id);
            dbContext.Entry(dcon).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return dcon;
        }
    }
}
