using Management.Domain.Workers;
using System;

namespace Management.Infrastructure.Repositories
{
    public class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        public WorkerRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public Worker NewWorker(string userName, string email)
        {
            var worker = new Worker(userName, email);
            if (worker.ValidOnAdd())
            {
                this.Add(worker);
                return worker;
            }
            else
                throw new Exception("Worker invalid");
        }
    }
}
