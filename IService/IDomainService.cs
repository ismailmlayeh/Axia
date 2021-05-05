using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Authentication;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
    public interface IDomainService
    {
        public IEnumerable<Domain> GetDomains();
        public Domain GetDomainById(int id);

       // public Domain FinfDomainByTitle(string title);

        public Domain AddDomain(Domain domain);

        public Domain UpdateDomain(Domain domain);

        public Domain DeleteDomain(int id);

       
    }
}
