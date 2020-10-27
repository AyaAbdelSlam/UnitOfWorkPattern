using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeUnitOfWork.App.Models;
using UnitOfWorkPattern.DAL.Models;
using UnitOfWorkPattern.DAL.Abstracts;
using UnitOfWorkPattern.DAL;

namespace EmployeeUnitOfWork.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, UnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()

        {
            var result = _unitOfWork.EmployeeRepository.Get().ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
