using System;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    [Route("api/")]
    public class PetsController : Controller
    {
        private Random rnd = new Random();
        private ImagesRepository _repository;

        public PetsController(){
          _repository = new ImagesRepository();
        }

        [HttpGet("pet")]
        public Image Get()
        {
            var id = rnd.Next(1, _repository.Count+1);
            return _repository.GetById(id);
        }
    }
}
