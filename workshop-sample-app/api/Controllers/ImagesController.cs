using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {
        [HttpGet]
        public IEnumerable<Image> Get()
        {
            return Images.All();
        }

        [HttpGet("{id}")]
        public Image Get(int id)
        {
            return Images.Get(id);
        }
    }
}
