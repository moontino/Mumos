using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mumos.Data;
using Mumos.Models;
using Mumos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mumos.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext db)
        {
            this.dbContext = db;
        }
        [HttpPost]
        public JsonResult Post(InputData input)
        {

            var ins = new Industry
            {
                Title = input.Title
            };

            foreach (var item in input.Technologies)
            {
                var tech = new Technology
                {
                    Title = item.Name,
                    ImageUrl = item.ImageUrl
                };
                ins.Technologies.Add(tech);

            }

            dbContext.Industries.Add(ins);
            dbContext.SaveChanges();
            return new JsonResult("Ok");

        }

        [HttpGet]
        public JsonResult Get()
        {

            var data = this.dbContext.Industries.Select(x => new InputData
            {
                Title = x.Title,
                Technologies = x.Technologies.Select(y => new InputTech
                {
                    Name = y.Title,
                    ImageUrl = y.ImageUrl
                }).ToList()
            }).ToList().OrderByDescending(x=>x.Technologies.Count);
            var json = JsonSerializer.Serialize(data);

            return new JsonResult(json);
        }
    }
}
