using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Conditionvalue
    {
        public Conditionvalue()
        {
            Task = new HashSet<Task>();
        }

        public int Idconditionvalue { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}
