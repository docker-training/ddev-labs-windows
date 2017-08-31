using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {
        private ImagesRepository _repository;

        public ImagesController(){
          _repository = new ImagesRepository();
        }

        [HttpGet]
        public IEnumerable<Image> Get()
        {
            return _repository.List();
        }

        [HttpGet("{id}")]
        public Image Get(int id)
        {
            return _repository.GetById(id);
        }
    }
}
