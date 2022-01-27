using Management.API.Services;
using Management.Domain.Workers;
using Microsoft.AspNetCore.Mvc;

namespace Management.API.Controllers
{
    [ApiController]
    [Route("api/workers")]
    public class WorkersController : ControllerBase
    {
        private readonly AllService _service;
        public WorkersController(AllService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetWorkers() => Ok(_service.GetWorkers());

        [HttpGet("{id}")]
        public ActionResult GetWorker(int id) => Ok(_service.GetWorker(id));

        [HttpPost]
        public ActionResult PostWorker(Worker worker) => Ok(_service.AddWorker(worker));
    }
}
