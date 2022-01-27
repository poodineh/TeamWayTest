using Management.Domain.Base;
using Management.Domain.WorkerShifts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Management.Domain.Workers
{
    [Table("Workers")]
    public partial class Worker : DeleteEntity<int>
    {
        public Worker()
        {
            WorkerShifts = new HashSet<WorkerShift>();
        }

        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [JsonIgnore]
        public virtual ICollection<WorkerShift> WorkerShifts { get; set; }
    }
}
