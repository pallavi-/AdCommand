using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class CSSMaster
    {
        public CSSMaster()
        {
            this.ConceptLinkCSSPolicyDetails = new List<ConceptLinkCSSPolicyDetail>();
            this.CSSPolicyDetails = new List<CSSPolicyDetail>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<ConceptLinkCSSPolicyDetail> ConceptLinkCSSPolicyDetails { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<CSSPolicyDetail> CSSPolicyDetails { get; set; }
    }
}
