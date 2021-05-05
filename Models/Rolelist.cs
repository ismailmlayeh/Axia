using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Rolelist
    {
        public Rolelist()
        {
            AspnetusersHasRolelist = new HashSet<AspnetusersHasRolelist>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspnetusersHasRolelist> AspnetusersHasRolelist { get; set; }
    }
}
