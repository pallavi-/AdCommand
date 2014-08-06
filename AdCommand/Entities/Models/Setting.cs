using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class Setting
    {
        public int ID { get; set; }
        public string KeyName { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
