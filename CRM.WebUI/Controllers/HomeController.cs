using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentService _departmentService;

        public HomeController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            return View(_departmentService.GetAll());
        }
    }
}