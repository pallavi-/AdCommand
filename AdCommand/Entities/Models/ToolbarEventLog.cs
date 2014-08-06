using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class ToolbarEventLog
    {
        public int ID { get; set; }
        public string TraceLevel { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public string HostName { get; set; }
        public System.DateTime TimeStamp { get; set; }
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
