using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Condition
    {
        public int Idcondition { get; set; }
        public int? Idworkflow { get; set; }
        public int? Iddocument { get; set; }
        public int? Iddomain { get; set; }
        public int? Conditionvalue { get; set; }
        public string ConditionTitle { get; set; }
        public string Requete { get; set; }
        public string ConditionFactor { get; set; }
        public string Iduser { get; set; }
        public int? Idtask { get; set; }

        public virtual Task IdtaskNavigation { get; set; }
        public virtual Aspnetusers IduserNavigation { get; set; }
        public virtual Workflow IdworkflowNavigation { get; set; }
    }
}
