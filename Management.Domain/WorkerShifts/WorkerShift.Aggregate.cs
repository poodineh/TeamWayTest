using Management.Domain.Shifts;
using Management.Domain.Workers;

namespace Management.Domain.WorkerShifts
{
    public partial class WorkerShift
    {
        public WorkerShift(Worker worker, Shift shift) : base()
        {
            WorkerId = worker.Id;
            ShiftId = shift.Id;
            Worker = worker;
            Shift = shift;

        }

        public bool ValidOnAdd()
        {
            return (ShiftId != 0 || Shift != null || WorkerId != 0 || Worker != null);
        }
    }
}
