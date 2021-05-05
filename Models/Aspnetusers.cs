using System;
using System.Collections.Generic;

namespace webapiworkflow.Models
{
    public partial class Aspnetusers
    {
        public Aspnetusers()
        {
            Aspnetuserclaims = new HashSet<Aspnetuserclaims>();
            Aspnetuserlogins = new HashSet<Aspnetuserlogins>();
            Aspnetuserroles = new HashSet<Aspnetuserroles>();
            AspnetusersHasRolelist = new HashSet<AspnetusersHasRolelist>();
            Aspnetusertokens = new HashSet<Aspnetusertokens>();
            Condition = new HashSet<Condition>();
            Task = new HashSet<Task>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string Role { get; set; }
        public int? Idrole { get; set; }

        public virtual ICollection<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual ICollection<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual ICollection<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual ICollection<AspnetusersHasRolelist> AspnetusersHasRolelist { get; set; }
        public virtual ICollection<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual ICollection<Condition> Condition { get; set; }
        public virtual ICollection<Task> Task { get; set; }
    }
}
