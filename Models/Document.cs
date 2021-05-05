using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Document
    {
        public Document()
        {
            Workflow = new HashSet<Workflow>();
        }

        public int Iddocument { get; set; }
        public int? Iddomain { get; set; }
        public string Status { get; set; }
        public string Referance { get; set; }
        public float? Mantant { get; set; }
        public int? Range { get; set; }
        public string Title { get; set; }

        public virtual Domain IddomainNavigation { get; set; }
        public virtual ICollection<Workflow> Workflow { get; set; }
    }
}
