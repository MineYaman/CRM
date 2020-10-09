using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Business.Abstract;
using CRM.Entities;
using CRM.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebUI.Controllers
{
    [Authorize(Roles = "admin,competent")]
    public class DepartmentController : Controller
    {
        private IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult ListDepartment()
        {
            return View(new DepartmentListModel()
            {
                Departments = _departmentService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult CreateDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDepartment(DepartmentModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Department()
                {
                    Name = model.Name,
                    Deleted = false
                };

                _departmentService.Create(entity);

                return RedirectToAction("ListDepartment");
            }

            return View(model);
        }


        [HttpPost]
        public IActionResult DeleteDepartment(int id)
        {
            var entity = _departmentService.GetById(id);

            if (entity != null)
            {
                entity.Deleted = true;
                _departmentService.Delete(entity);
            }

            return RedirectToAction("ListDepartment");
        }

        
        public IActionResult EditDepartment()
        {
            return View();
        }
    }
}