using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Images.All();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return ImagesController.Get(id);
        }
    }
}
