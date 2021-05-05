using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Task
    {
        public Task()
        {
            Calendar = new HashSet<Calendar>();
            Condition = new HashSet<Condition>();
            Taskbasket = new HashSet<Taskbasket>();
        }

        public int Idtask { get; set; }
        public string TaskTitle { get; set; }
        public string TaskStatus { get; set; }
        public string Iduser { get; set; }
        public DateTime? Begin { get; set; }
        public DateTime? Deadline { get; set; }
        public string Attachement { get; set; }
        public int? Idworkflow { get; set; }
        public int? Idconditionvalue { get; set; }

        public virtual Conditionvalue IdconditionvalueNavigation { get; set; }
        public virtual Aspnetusers IduserNavigation { get; set; }
        public virtual Workflow IdworkflowNavigation { get; set; }
        public virtual ICollection<Calendar> Calendar { get; set; }
        public virtual ICollection<Condition> Condition { get; set; }
        public virtual ICollection<Taskbasket> Taskbasket { get; set; }
    }
}
