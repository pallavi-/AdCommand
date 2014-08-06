using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class PopUpLandingSite
    {
        public PopUpLandingSite()
        {
            this.PopUpAds = new List<PopUpAd>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string DomainURL { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<PopUpAd> PopUpAds { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
