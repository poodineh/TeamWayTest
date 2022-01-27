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
    public class WorkerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShiftRepository _shiftRepository;
        private readonly IWorkerRepository _workerRepository;
        private readonly IWorkerShiftRepository _workerShiftRepository;

        public WorkerService(IUnitOfWork unitOfWork
            , IShiftRepository ShiftRepository
            , IWorkerRepository userRepository
            , IWorkerShiftRepository workerShiftRepository)
        {
            _unitOfWork = unitOfWork;
            _shiftRepository = ShiftRepository;
            _workerRepository = userRepository;
            _workerShiftRepository = workerShiftRepository;
        }

        //public async Task<bool> AddAllEntitiesAsync()
        //{
        //    // create new Department
        //    var departMentName = $"department_{Guid.NewGuid():N}";
        //    var department = _departmentRepository.AddDepartment(departMentName);

        //    // create new User with above Department
        //    var userName = $"user_{Guid.NewGuid():N}";
        //    var userEmail = $"{Guid.NewGuid():N}@gmail.com";
        //    var user = _userRepository.NewUser(userName, userEmail, department);

        //    // create new Salary with above User
        //    float coefficientsSalary = new Random().Next(1, 15);
        //    float workdays = 22;
        //    var salary = _salaryRepository.AddUserSalary(user, coefficientsSalary, workdays);

        //    // Commit all changes with one single commit
        //    var saved = await _unitOfWork.CommitAsync();

        //    return saved > 0;
        //}

        public List<Worker> GetWorkers()
        {
            return  _workerRepository.List(x=>x.Id>0).ToList();
        }


        public Worker GetWorker(int id)
        {
            return _workerRepository.List(x => x.Id == id).FirstOrDefault();
        }
    }
}
