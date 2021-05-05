using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiworkflow.Models;

namespace webapiworkflow.IService
{
    public interface IDocumentService
    {
        public IEnumerable<Document> GetDocuments();

        public IEnumerable<Document> GetDocumentByDomain(int id);

       

        public Document AddDocument(Document doc);

        public Document UpdateDocument(Document doc);

        public Document DeleteDocument(int id);
    }
}
