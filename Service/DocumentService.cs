using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.IService;
using webapiworkflow.Models;

namespace webapiworkflow.Service
{
    public class DocumentService : IDocumentService
    {
        workflowapiContext dbContext;

        public DocumentService(workflowapiContext _db)
            {
              dbContext = _db;
            }

        public IEnumerable<Document> GetDocuments()
        {
           var Doc = dbContext.Document.ToList();
            return Doc;

        }

        public IEnumerable<Document> GetDocumentByDomain(int id)
        {
            var dd = dbContext.Document.Where(x => x.Iddomain == id).ToList();
            return dd;
        }



        

        public Document AddDocument(Document doc)
        {

            if (doc != null)
            {

                if (dbContext.Document.Where(x => x.Iddocument == doc.Iddocument).FirstOrDefault() == null)
                {
                    dbContext.Document.Add(doc);
                    dbContext.SaveChanges();
                    return doc;
                }
               
            }
            return null;
            
        }

        public Document UpdateDocument(Document doc)
        {
            dbContext.Entry(doc).State = EntityState.Modified;
            dbContext.SaveChanges();
            return doc;
        }

        public Document DeleteDocument (int id )
        {
            var deldoc = dbContext.Document.FirstOrDefault(x => x.Iddocument == id);

           
            dbContext.Entry(deldoc).State = EntityState.Deleted;



            dbContext.SaveChanges();
            return deldoc;
        }
    }
}
