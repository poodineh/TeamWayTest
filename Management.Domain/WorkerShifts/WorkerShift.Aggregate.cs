using Management.Domain.Shifts;
using Management.Domain.Workers;
using System;

namespace Management.Domain.WorkerShifts
{
    public partial class WorkerShift
    {
        public WorkerShift(Worker worker, Shift shift, DateTime date) : base()
        {
            WorkerId = worker.Id;
            ShiftId = shift.Id;
            Worker = worker;
            Shift = shift;
            CalndarDay = date;
        }

        public bool ValidOnAdd()
        {
            
            return (ShiftId != 0 || Shift != null || WorkerId != 0 || Worker != null);
        }
    }
}
