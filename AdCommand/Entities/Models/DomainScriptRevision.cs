using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class DomainScriptRevision
    {
        public long ID { get; set; }
        public string URLPattern { get; set; }
        public string Script { get; set; }
        public string Html { get; set; }
        public string Style { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<short> IsJQuery { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Created { get; set; }
        public string Version { get; set; }
        public string ChangeLog { get; set; }
        public Nullable<System.DateTime> RevisionCreated { get; set; }
        public Nullable<long> OldDomainScriptID { get; set; }
        public virtual Country Country { get; set; }
        public virtual DomainScript DomainScript { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
