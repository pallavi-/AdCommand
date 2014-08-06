using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class Filter
    {
        public Filter()
        {
            this.FilterDistributors = new List<FilterDistributor>();
            this.FilterDistributorScripts = new List<FilterDistributorScript>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public Nullable<short> DateType { get; set; }
        public string UserList { get; set; }
        public Nullable<short> DomainType { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<short> DaysAfterUserInstall { get; set; }
        public string DomainList { get; set; }
        public Nullable<short> UserType { get; set; }
        public Nullable<short> SearchAds { get; set; }
        public Nullable<short> FeedScriptsType { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<short> SearchAdsTime { get; set; }
        public Nullable<short> InterstitialAdsTime { get; set; }
        public Nullable<short> PopupAdsTime { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Country Country { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<FilterDistributor> FilterDistributors { get; set; }
        public virtual ICollection<FilterDistributorScript> FilterDistributorScripts { get; set; }
    }
}
