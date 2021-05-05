using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Authentication;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class DomainService : IDomainService
    {
        workflowapiContext dbContext;

        public DomainService(workflowapiContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Domain> GetDomains()
        {
            var D = dbContext.Domain.ToList();
            return D;
        }

        public Domain GetDomainById(int id)
        {
            var c = dbContext.Domain.FirstOrDefault(x => x.Iddomain == id);
            return c;
        }







        public Domain AddDomain(Domain domain)
        {


            var checktitle = from d in dbContext.Domain
                             where d.DomainTitle == domain.DomainTitle

                             select d;



            if (checktitle.FirstOrDefault() == null && (domain != null))
            {
                dbContext.Domain.Add(domain);
                dbContext.SaveChanges();
                return domain;
            }


            
             return null;






























        }
      
 

        public Domain UpdateDomain(Domain domain)
        {
            dbContext.Entry(domain).State = EntityState.Modified;
            dbContext.SaveChanges();
            return domain;
        }

        public Domain DeleteDomain(int id)
        {
            var ddomain = dbContext.Domain.FirstOrDefault(x => x.Iddomain == id);

           
            dbContext.Entry(ddomain).State = EntityState.Deleted;

            //foreach (var idd in dbContext.Document)
            //{
            //    if (idd.Iddomain == id)
            //    {
            //        dbContext.Document.Remove(idd);
            //    }
            //}

            dbContext.SaveChanges();
            return ddomain;
        }

    }
}
