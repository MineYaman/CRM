using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Business.Abstract;
using CRM.Entities;
using CRM.WebUI.Identity;
using CRM.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebUI.Controllers
{
    public class DepartmentAttendantController : Controller
    {
        private IDepartmentAttendantService _departmentAttendantService;
        private IDepartmentService _departmentService;
        private IUserService _userService;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public DepartmentAttendantController(IDepartmentAttendantService departmentAttendantService, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IDepartmentService departmentService, IUserService userService)
        {
            _departmentAttendantService = departmentAttendantService;
            _userManager = userManager;
            _roleManager = roleManager;
            _departmentService = departmentService;
            _userService = userService;
        }
        public IActionResult ListDepartmentAttendant()
        {
            var users = _userManager.Users;

            return View(Tuple.Create<DepartmentAttendantModel, DepartmentListModel, List<ApplicationUser>>
                (new DepartmentAttendantModel
                {
                    DepartmentAttendants = _departmentAttendantService.GetAll()
                }, new DepartmentListModel()
                {
                    Departments = _departmentService.GetAll()
                }, new List<ApplicationUser>(users)));
        }

        [HttpPost]
        public IActionResult DeleteDepartmentStaff(int departmentId, string userId)
        {
            _departmentAttendantService.DeleteDepartmentAttendant(departmentId, userId);
            return Redirect("/departmentattendant/listdepartmentattendant/");
        }

        [HttpGet]
        public IActionResult CreateDepartmentAttendant()
        {
            var users = _userManager.Users;

            return View(Tuple.Create<DepartmentListModel, List<ApplicationUser>>(new DepartmentListModel()
            {
                Departments = _departmentService.GetAll()
            }, new List<ApplicationUser>(users)));
        }


        [HttpPost]
        public IActionResult CreateDepartmentAttendant(int depId, string userId)
        {
            if (ModelState.IsValid)
            {
                var entity = new DepartmentAttendant()
                {
                    DepartmentId = depId,
                    UserId = userId
                };

                _departmentAttendantService.Create(entity);

                return RedirectToAction("ListDepartmentAttendant");
            }

            return View();
        }
    }
}