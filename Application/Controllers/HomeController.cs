using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using ORM.Interfaces;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodoRepository _todoRepository;

        public HomeController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IActionResult Index()
        {
            var resultado = _todoRepository.GetAll();
            return View(_todoRepository.GetAll());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Entities.ToDo obj)
        {
            return View();
        }
    }
}
