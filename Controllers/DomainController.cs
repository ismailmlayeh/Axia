using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Authentication;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DomainController : ControllerBase
    {
        private readonly IDomainService Idomainservice;
        private readonly IDocumentService Idocumentservice;

        public DomainController(IDomainService Idomain, IDocumentService Idoc)
        {
            Idomainservice = Idomain;
            Idocumentservice = Idoc;

        }
        

        [HttpGet]

       // [Route("GetDomain")]
        
        public IEnumerable<Domain> GetDomains()
        {
            return Idomainservice.GetDomains();
        }

        [HttpGet("{id}")]
        //[Route("GetDomainById")]
        public Domain GetDomainById(int id)
        {
            return Idomainservice.GetDomainById(id);
        }


        [HttpPost]
        //[Route("AddDomain")]
        public Domain AddDomain(Domain domain)
        {
            
            return Idomainservice.AddDomain(domain);
            
        }


        [HttpPut("{id}")]
      //  [Route("UpdateDomain")]

        public Domain UpdateDomain(int id ,Domain domain)
        {
            domain.Iddomain = id;
            return Idomainservice.UpdateDomain(domain);
        }


        [HttpDelete("{id}")]
       // [Route("DeleteDomain")]
        public Domain DeleteDomain(int id)
        {
            
            return Idomainservice.DeleteDomain(id);
        }
    }
}
