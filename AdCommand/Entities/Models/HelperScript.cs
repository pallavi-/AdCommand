using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class HelperScript
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Script { get; set; }
        public Nullable<short> Type { get; set; }
        public Nullable<short> Minimized { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
