using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class AssetScript
    {
        public AssetScript()
        {
            this.DistributorCodeAssetScripts = new List<DistributorCodeAssetScript>();
        }

        public int ID { get; set; }
        public System.Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Script { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string Browser { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Country Country { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<DistributorCodeAssetScript> DistributorCodeAssetScripts { get; set; }
    }
}
