using Management.Domain.Interfaces;
using Management.Domain.Shifts;
using Management.Domain.Workers;
using System;

namespace Management.Domain.WorkerShifts
{
    public interface IWorkerShiftRepository : IRepository<WorkerShift>
    {
        WorkerShift AddWorkerShift(Worker worker,Shift shift, DateTime date);
    }
}
