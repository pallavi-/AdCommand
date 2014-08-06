using System;
using System.Collections.Generic;

namespace RRM.Entities.Models
{
    public partial class UpdateSetting
    {
        public UpdateSetting()
        {
            this.UpdateAssignments = new List<UpdateAssignment>();
        }

        public int ID { get; set; }
        public int ProductID { get; set; }
        public string UpdateURL { get; set; }
        public string CustomUpdater { get; set; }
        public string Version { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<UpdateAssignment> UpdateAssignments { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
