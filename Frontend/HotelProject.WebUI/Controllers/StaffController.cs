﻿using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient(); //istemci
            var responseMessage = await client.GetAsync("http://localhost:51109/api/Staff"); //istek aldığımzı adres
            if (responseMessage.IsSuccessStatusCode) //gelen veri başarılıysa
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();//gelen json veriyi dönüştürdüm
                var values = JsonConvert.DeserializeObject<List<StaffViwModel>>(jsonData);
                return View(values); 
            }
            return View();
        }

        [HttpGet]

        public IActionResult AddStaf()
        {

            return View();
        }

        [HttpPost]
        public async Task <IActionResult> AddStaff()
        {
            return View();

        }










    }
}
