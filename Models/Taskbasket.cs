using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Taskbasket
    {
        public int Idtaskbasket { get; set; }
        public int? Idtask { get; set; }

        public virtual Task IdtaskNavigation { get; set; }
    }
}
