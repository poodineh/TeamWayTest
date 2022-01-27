using Management.Domain.Interfaces;
using Management.Domain.Shifts;
using Management.Domain.Workers;

namespace Management.Domain.WorkerShifts
{
    public interface IWorkerShiftRepository : IRepository<WorkerShift>
    {
        WorkerShift AddWorkerShift(Worker worker,Shift shift);
    }
}
