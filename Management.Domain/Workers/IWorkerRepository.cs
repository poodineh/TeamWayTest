using Management.Domain.Interfaces;


namespace Management.Domain.Workers
{
    public interface IWorkerRepository : IRepository<Worker>
    {
        Worker NewWorker(string userName, string email);
    }
}
