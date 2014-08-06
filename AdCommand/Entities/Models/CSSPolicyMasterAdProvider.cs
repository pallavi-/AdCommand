using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class CSSPolicyMasterAdProvider
    {
        public int ID { get; set; }
        public int CSSPolicyMasterID { get; set; }
        public int AdProviderID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual AdProvider AdProvider { get; set; }
        public virtual CSSPolicyMaster CSSPolicyMaster { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
