using System;
using Microsoft.AspNetCore.Mvc;
using api.Models

namespace api.Controllers
{
    [Route("api/")]
    public class PetsController : Controller
    {
        private Random rnd = new Random();

        [HttpGet("pet")]
        public Image Get()
        {
            var index = rnd.Next(0, Images.Count);
            return Images.Get(index);
        }
    }
}