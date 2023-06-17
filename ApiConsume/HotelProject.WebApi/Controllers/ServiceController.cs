using HotelProject.BusinessLayer.Absract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _ServiceService;


        public ServiceController(IServiceService ServiceService)
        {
            _ServiceService = ServiceService;
        }
        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _ServiceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _ServiceService.TInsert(service);
            return Ok();


        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _ServiceService.TGetByID(id);
            _ServiceService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _ServiceService.TUpdate(service);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _ServiceService.TGetByID(id);
            return Ok(values);
        }


    }
}
