using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyNLayerProjectMVC.Core.Models;
using UdemyNLayerProjectMVC.Core.Services;

namespace UdemyNLayerProjectMVC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<Person> _personService;

        public PersonsController(IService<Person> service)
        {
            _personService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _personService.GetAllAsync();
            return Ok(persons);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Person person)

        {
            var newperson = await _personService.AddAsync(person);

            return Ok(newperson);
        }
    }
}