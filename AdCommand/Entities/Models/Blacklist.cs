using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class Blacklist
    {
        public int ID { get; set; }
        public System.Guid Guid { get; set; }
        public byte Blacklist1 { get; set; }
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
