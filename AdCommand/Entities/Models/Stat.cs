using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class Stat
    {
        public int ID { get; set; }
        public int Installs { get; set; }
        public int Searches { get; set; }
        public int Browse { get; set; }
        public int Uninstalls { get; set; }
        public int Active { get; set; }
        public Nullable<System.DateTime> Day { get; set; }
        public Nullable<int> Hour { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
