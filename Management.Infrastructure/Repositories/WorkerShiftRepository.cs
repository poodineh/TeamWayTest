using Management.Domain.WorkerShifts;
using Management.Domain.Interfaces;
using Management.Domain.Workers;
using System;
using System.Collections.Generic;
using System.Text;
using Management.Domain.Shifts;

namespace Management.Infrastructure.Repositories
{
    public class WorkerShiftRepository : Repository<WorkerShift>, IWorkerShiftRepository
    {
        public WorkerShiftRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public WorkerShift AddWorkerShift(Worker worker, Shift shift)
        {
            var workerShift = new WorkerShift(worker, shift);
            if (workerShift.ValidOnAdd())
            {
                this.Add(workerShift);
                return workerShift;
            }
            else
                throw new Exception("workerShift invalid");
        }
    }
}
