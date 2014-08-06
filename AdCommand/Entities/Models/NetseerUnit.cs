using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class NetseerUnit
    {
        public NetseerUnit()
        {
            this.NetseerDistributorCodes = new List<NetseerDistributorCode>();
            this.NetseerDomains = new List<NetseerDomain>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Style { get; set; }
        public string Html { get; set; }
        public string Script { get; set; }
        public int NetseerLandingLinkID { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public Nullable<int> ProductID { get; set; }
        public short ConceptLimit { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<NetseerDistributorCode> NetseerDistributorCodes { get; set; }
        public virtual ICollection<NetseerDomain> NetseerDomains { get; set; }
        public virtual NetseerLandingLink NetseerLandingLink { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
