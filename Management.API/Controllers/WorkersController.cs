using Management.API.Services;
using Management.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Management.API.Controllers
{
    [ApiController]
    [Route("api/workers")]
    public class WorkersController : ControllerBase
    {
        private readonly WorkerService _service;
        public WorkersController(WorkerService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetWorkers() => Ok(_service.GetWorkers());

        [HttpGet("{id}")]
        public ActionResult GetWorker(int id) => Ok(_service.GetWorker(id));
    }
}
