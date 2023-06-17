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
    public class SubscribeController : ControllerBase
    {

        private readonly ISubscribeService _SubscribeService;


        public SubscribeController(ISubscribeService SubscribeService)
        {
            _SubscribeService = SubscribeService;
        }
        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _SubscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Subscribe subscribe)
        {
            _SubscribeService.TInsert(subscribe);
            return Ok();


        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _SubscribeService.TGetByID(id);
            _SubscribeService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Subscribe subscribe)
        {
            _SubscribeService.TUpdate(subscribe);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _SubscribeService.TGetByID(id);
            return Ok(values);
        }





    }
}
