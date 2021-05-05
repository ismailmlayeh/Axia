using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Calendar
    {
        public int Idcalendar { get; set; }
        public int? Idtask { get; set; }

        public virtual Task IdtaskNavigation { get; set; }
    }
}
