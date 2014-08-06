using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class PopUpAd
    {
        public PopUpAd()
        {
            this.PopUpDomains = new List<PopUpDomain>();
            this.PopUpPerDistributors = new List<PopUpPerDistributor>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<short> Type { get; set; }
        public Nullable<short> Trigger { get; set; }
        public Nullable<short> Width { get; set; }
        public Nullable<short> Height { get; set; }
        public Nullable<short> Frequency { get; set; }
        public Nullable<short> IsEnabled { get; set; }
        public Nullable<int> PopUpAdLandingSiteID { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public System.DateTime Created { get; set; }
        public virtual PopUpLandingSite PopUpLandingSite { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<PopUpDomain> PopUpDomains { get; set; }
        public virtual ICollection<PopUpPerDistributor> PopUpPerDistributors { get; set; }
    }
}
