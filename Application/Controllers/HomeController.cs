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
            return View();
        }
    }
}
