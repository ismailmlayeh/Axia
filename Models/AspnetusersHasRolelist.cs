using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class AspnetusersHasRolelist
    {
        public string AspnetusersId { get; set; }
        public int RolelistId { get; set; }

        public virtual Aspnetusers Aspnetusers { get; set; }
        public virtual Rolelist Rolelist { get; set; }
    }
}
