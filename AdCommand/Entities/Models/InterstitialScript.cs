using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class InterstitialScript
    {
        public InterstitialScript()
        {
            this.InterstitialScriptDomains = new List<InterstitialScriptDomain>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Style { get; set; }
        public string Html { get; set; }
        public string Script { get; set; }
        public short Type { get; set; }
        public short Frequency { get; set; }
        public Nullable<short> Timeout { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public Nullable<int> InterstitialLandingSiteID { get; set; }
        public Nullable<short> TriggerType { get; set; }
        public Nullable<int> ProductID { get; set; }
        public virtual InterstitialLandingSite InterstitialLandingSite { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<InterstitialScriptDomain> InterstitialScriptDomains { get; set; }
    }
}
