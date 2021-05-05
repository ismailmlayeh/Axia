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
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService Idocumentservice;

        public DocumentController(IDocumentService Idoc)
        {
            Idocumentservice = Idoc;
        }


        [HttpGet]
        
        public IEnumerable<Document> GetDocuments()
        {
            return Idocumentservice.GetDocuments();
            
        }

     

        //docbydomain
        [HttpGet("{id}")]
        
        public IEnumerable<Document> GetDocumentByDomain(int id)
        {
            return Idocumentservice.GetDocumentByDomain(id);
        }
        //




        [HttpPost]
        
        public Document AddDocument(Document doc)
        {
           return Idocumentservice.AddDocument(doc);
        }


        [HttpPut("{id}")]
        
        public Document UpdateDocument(int id,Document doc)
        {
            doc.Iddocument = id;
            return Idocumentservice.UpdateDocument(doc);
        }

        [HttpDelete("{id}")]
        
        public Document DeleteDocument(int id)
        {
            return Idocumentservice.DeleteDocument(id);
        }
    }
}
