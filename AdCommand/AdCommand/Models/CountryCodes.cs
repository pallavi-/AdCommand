using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RRM.Entities.Models;

namespace Web.AdCommand.Models
{
    public class CountryMaster
    {
        public CountryMaster()
        {
        }

        public List<CountryDetails> GetCountries(AdcommandContext AdDBContext)
        {
            List<CountryDetails> countryList = new List<CountryDetails>();

            //HashSet<RRM.Entities.Models.CountryMaster> _countries = this.cachedTables.Countries;

            countryList = (from CC in AdDBContext.Countries
                           select new CountryDetails
                           {
                               ID = CC.ID,
                               Name = CC.Name,
                               CountryCode = CC.CountryCode,
                               CreatedByName = CC.User.Name,
                               ModifiedByName = CC.User1.Name,
                               Created = CC.Created,
                               Modified = CC.Modified
                           }).ToList();

            return countryList;
        }


        public CountryDetails GetEditableCountry(AdcommandContext AdDBContext, int countryID)
        {
            return (from country in GetCountries(AdDBContext) where country.ID == countryID select country).FirstOrDefault();
        }
    }

    public class CountryDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public string CreatedByName { get; set; }
        public string ModifiedByName { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
    }
}
