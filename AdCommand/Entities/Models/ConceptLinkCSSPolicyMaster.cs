using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class ConceptLinkCSSPolicyMaster
    {
        public ConceptLinkCSSPolicyMaster()
        {
            this.ConceptLinkCSSPolicyDetails = new List<ConceptLinkCSSPolicyDetail>();
        }

        public int ID { get; set; }
        public long DomainScriptID { get; set; }
        public int DistributorID { get; set; }
        public int CountryID { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyDetail> ConceptLinkCSSPolicyDetails { get; set; }
        public virtual Country Country { get; set; }
        public virtual Distributor Distributor { get; set; }
        public virtual DomainScript DomainScript { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
