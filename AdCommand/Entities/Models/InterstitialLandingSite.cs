using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class InterstitialLandingSite
    {
        public InterstitialLandingSite()
        {
            this.InterstitialScripts = new List<InterstitialScript>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string DomainURL { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<InterstitialScript> InterstitialScripts { get; set; }
    }
}
