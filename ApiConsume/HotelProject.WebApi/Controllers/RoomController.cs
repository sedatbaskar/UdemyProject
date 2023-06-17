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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _RoomService;


        public RoomController(IRoomService RoomService)
        {
            _RoomService = RoomService;
        }
        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _RoomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _RoomService.TInsert(room);
            return Ok();


        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _RoomService.TGetByID(id);
            _RoomService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _RoomService.TUpdate(room);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _RoomService.TGetByID(id);
            return Ok(values);
        }


    }
}
