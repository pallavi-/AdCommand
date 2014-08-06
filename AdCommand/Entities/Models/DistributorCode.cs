using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class DistributorCode
    {
        public DistributorCode()
        {
            this.BinFilesQueues = new List<BinFilesQueue>();
            this.DistributorCodeAssetScripts = new List<DistributorCodeAssetScript>();
            this.FilterDistributors = new List<FilterDistributor>();
            this.MintCallLimits = new List<MintCallLimit>();
            this.NamiMappings = new List<NamiMapping>();
            this.NetseerDistributorCodes = new List<NetseerDistributorCode>();
            this.PopUpPerDistributors = new List<PopUpPerDistributor>();
            this.UpdateAssignments = new List<UpdateAssignment>();
        }

        public int ID { get; set; }
        public int DistributorID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string AffiliateID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<BinFilesQueue> BinFilesQueues { get; set; }
        public virtual Country Country { get; set; }
        public virtual Distributor Distributor { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<DistributorCodeAssetScript> DistributorCodeAssetScripts { get; set; }
        public virtual ICollection<FilterDistributor> FilterDistributors { get; set; }
        public virtual ICollection<MintCallLimit> MintCallLimits { get; set; }
        public virtual ICollection<NamiMapping> NamiMappings { get; set; }
        public virtual ICollection<NetseerDistributorCode> NetseerDistributorCodes { get; set; }
        public virtual ICollection<PopUpPerDistributor> PopUpPerDistributors { get; set; }
        public virtual ICollection<UpdateAssignment> UpdateAssignments { get; set; }
    }
}
