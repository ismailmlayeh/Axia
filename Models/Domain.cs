using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Domain
    {
        public Domain()
        {
            Document = new HashSet<Document>();
        }

        public int Iddomain { get; set; }
        public string DomainTitle { get; set; }
        public string DomainDescription { get; set; }

        public virtual ICollection<Document> Document { get; set; }
    }
}
