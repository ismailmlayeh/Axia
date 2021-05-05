using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Workflow
    {
        public Workflow()
        {
            Condition = new HashSet<Condition>();
            Task = new HashSet<Task>();
        }

        public int Idworkflow { get; set; }
        public string WorkflowTitle { get; set; }
        public int? Iddocument { get; set; }

        public virtual Document IddocumentNavigation { get; set; }
        public virtual ICollection<Condition> Condition { get; set; }
        public virtual ICollection<Task> Task { get; set; }
    }
}
