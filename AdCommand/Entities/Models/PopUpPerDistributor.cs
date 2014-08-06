using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class PopUpPerDistributor
    {
        public int ID { get; set; }
        public int DistributorCodeID { get; set; }
        public int PopUpAdID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual DistributorCode DistributorCode { get; set; }
        public virtual PopUpAd PopUpAd { get; set; }
        public virtual PopUpPerDistributor PopUpPerDistributor1 { get; set; }
        public virtual PopUpPerDistributor PopUpPerDistributor2 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
