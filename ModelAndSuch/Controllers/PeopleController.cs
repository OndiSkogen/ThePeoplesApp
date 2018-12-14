using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelAndSuch.Models;
using ModelAndSuch.Models.Entities;

namespace ModelAndSuch.Controllers
{
    public class PeopleController : Controller
    {
        PeopleService service;

        public PeopleController(PeopleService service)
        {
            this.service = service;
        }

        [Route("")]
        public async Task<IActionResult> Index()
        {
            return View(await service.GetAllPeopleAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person p)
        {
            if (!ModelState.IsValid)
                return View(p);

            await service.AddPersonAsync(p);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            return View(await service.GetPersonByIdAsync(id));
        }
    }
}