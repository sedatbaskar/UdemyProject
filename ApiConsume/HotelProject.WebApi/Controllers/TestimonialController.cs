﻿using HotelProject.BusinessLayer.Absract;
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
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;


        public TestimonialController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _TestimonialService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _TestimonialService.TInsert(testimonial);
            return Ok();


        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _TestimonialService.TGetByID(id);
            _TestimonialService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _TestimonialService.TUpdate(testimonial);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _TestimonialService.TGetByID(id);
            return Ok(values);
        }

    }
}
