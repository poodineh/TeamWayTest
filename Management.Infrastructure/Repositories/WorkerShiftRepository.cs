using Management.Domain.WorkerShifts;
using Management.Domain.Interfaces;
using Management.Domain.Workers;
using System;
using System.Collections.Generic;
using System.Text;
using Management.Domain.Shifts;
using System.Linq;

namespace Management.Infrastructure.Repositories
{
    public class WorkerShiftRepository : Repository<WorkerShift>, IWorkerShiftRepository
    {
        public WorkerShiftRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public WorkerShift AddWorkerShift(Worker worker, Shift shift, DateTime date)
        {
            var workerShift = new WorkerShift(worker, shift, date);
            var ws = new List<WorkerShift>(this.List(x => (x.WorkerId == worker.Id && x.CalndarDay.Date == date.Date)));

            if (workerShift.ValidOnAdd() && !ws.Any())
            {
                this.Add(workerShift);
                return workerShift;
            }
            else
                throw new Exception("workerShift invalid");
        }
    }
}
