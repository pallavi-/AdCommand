using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class ConceptLinkCSSPolicyDetail
    {
        public int ID { get; set; }
        public int ConceptLinkCSSPolicyMasterID { get; set; }
        public int CSSMasterID { get; set; }
        public string StyleValue { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ConceptLinkCSSPolicyMaster ConceptLinkCSSPolicyMaster { get; set; }
        public virtual CSSMaster CSSMaster { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
