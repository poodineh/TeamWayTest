﻿using Management.Domain.Base;
using Management.Domain.Shifts;
using Management.Domain.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Management.Domain.WorkerShifts
{
    [Table("WorkerShifts")]
    public partial class WorkerShift : AuditEntity<long>
    {
        public WorkerShift()
        {

        }
        public int WorkerId { get; set; }

        public int ShiftId { get; set; }

        public DateTime CalndarDay { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(WorkerId))]
        public virtual Worker Worker { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(ShiftId))]
        public virtual Shift Shift { get; set; }
    }
}
