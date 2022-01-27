using Management.Domain.Base;
using Management.Domain.WorkerShifts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Management.Domain.Shifts
{
    [Table("Shifts")]
    public partial class Shift : DeleteEntity<int>
    {
        public Shift()
        {
            WorkerShifts = new HashSet<WorkerShift>();
        }

        public DateTime StartTime{ get; set; }

        public DateTime EndTime{ get; set; }

        public bool OnlyWorkDays { get; set; }

        [JsonIgnore]
        public virtual ICollection<WorkerShift> WorkerShifts { get; set; }
    }
}
