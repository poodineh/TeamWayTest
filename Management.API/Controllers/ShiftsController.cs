using Microsoft.AspNetCore.Mvc;
using Management.API.Services;


namespace Management.API.Controllers
{
    public class ShiftsController : ControllerBase
    {
        private readonly AllService _service;
        public ShiftsController(AllService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetShifts() => Ok(_service.GetShifts());
    }
}
