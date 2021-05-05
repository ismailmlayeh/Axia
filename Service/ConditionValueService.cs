using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class ConditionValueService : IConditionValueService
    {
        workflowapiContext dbContext;
        
        public ConditionValueService(workflowapiContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Conditionvalue> GetConditionvalues()
        {
           var cv = dbContext.Conditionvalue.ToList();
            return cv;
        }

        public Conditionvalue GetConditionvalueById(int id)
        {
            var c = dbContext.Conditionvalue.FirstOrDefault(x => x.Idconditionvalue == id);


            return c;


        }

        public Conditionvalue AddConditionValue(Conditionvalue conval)
        {


            var checktitle = from d in dbContext.Conditionvalue
                             where d.Title == conval.Title

                             select d;



            if (checktitle.FirstOrDefault() == null && (conval != null))
                
            {
                dbContext.Conditionvalue.Add(conval);
            dbContext.SaveChanges();
            return conval;
            }
            return null;
        }

        public Conditionvalue UpdateConditionValue(Conditionvalue conval)
        {
             dbContext.Entry(conval).State = EntityState.Modified;
             dbContext.SaveChanges();
                return conval;
        }

        public Conditionvalue DeleteConditionValue (int id)
        {
            var dconval = dbContext.Conditionvalue.FirstOrDefault(x => x.Idconditionvalue == id);
            dbContext.Entry(dconval).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return dconval;
        }
    }
}
