using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RRM.Entities.Models;

namespace Web.AdCommand.Models
{
    public class AdProviderMaster
    {
        public List<AdProviderDetails> GetAdProviders(AdcommandContext AdDBContext)
        {
            List<AdProviderDetails> adProviderList = new List<AdProviderDetails>();
            adProviderList = (from ap in AdDBContext.AdProviders
                              select new AdProviderDetails
                              {
                                  ID = ap.ID,
                                  Name = ap.Name,
                                  IsEnabled = ap.IsEnabled,
                                  CreatedByName = ap.User.Name,
                                  ModifiedByName = ap.User1.Name,
                                  Created = ap.Created,
                                  Modified = ap.Modified
                              }).ToList();
            return adProviderList;
        }
    }
    public class AdProviderDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedByName { get; set; }
        public System.DateTime Modified { get; set; }

    }
}