using Management.Domain.WorkerShifts;
using Management.Domain.Interfaces;
using Management.Domain.Shifts;
using Management.Domain.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.API.Services
{
    public class AllService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShiftRepository _shiftRepository;
        private readonly IWorkerRepository _workerRepository;
        private readonly IWorkerShiftRepository _workerShiftRepository;

        public AllService(IUnitOfWork unitOfWork
            , IShiftRepository ShiftRepository
            , IWorkerRepository userRepository
            , IWorkerShiftRepository workerShiftRepository)
        {
            _unitOfWork = unitOfWork;
            _shiftRepository = ShiftRepository;
            _workerRepository = userRepository;
            _workerShiftRepository = workerShiftRepository;
        }


        public List<Worker> GetWorkers()
        {
            return  _workerRepository.List(x=>x.Id>0).ToList();
        }

        public Worker GetWorker(int id)
        {
            return _workerRepository.List(x => x.Id == id).FirstOrDefault();
        }

        public List<Shift> GetShifts()
        {
            return _shiftRepository.List(x => x.Id > 0).ToList();
        }

        public Worker AddWorker(Worker worker)
        {
            _workerRepository.Add(worker);
            return worker;
        }



    }
}
