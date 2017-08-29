using System;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/")]
    public class PetsController : Controller
    {
        private Random rnd = new Random();

        [HttpGet("pet")]
        public Image Get()
        {
            var id = rnd.Next(1, Images.Count+1);
            return Images.Get(id);
        }
    }
}
