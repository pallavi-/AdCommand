using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class AdPolicyDetail
    {
        public int ID { get; set; }
        public int AdPolicyMasterID { get; set; }
        public int AdProviderID { get; set; }
        public int Priority { get; set; }
        public bool IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual AdProvider AdProvider { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
