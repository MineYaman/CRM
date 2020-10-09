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
    public class DepartmentStaffController : Controller
    {
        private IDepartmentStaffService _departmentStaffService;
        private IDepartmentService _departmentService;
        private IUserService _userService;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public DepartmentStaffController(IDepartmentStaffService departmentStaffService, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IDepartmentService departmentService, IUserService userService)
        {
            _departmentStaffService = departmentStaffService;
            _userManager = userManager;
            _roleManager = roleManager;
            _departmentService = departmentService;
            _userService = userService;
        }
        public IActionResult ListDepartmentStaff()
        {
            var users = _userManager.Users;

            return View(Tuple.Create<DepartmentStaffModel,DepartmentListModel, List<ApplicationUser>>
                (new DepartmentStaffModel{
                    DepartmentStaffs = _departmentStaffService.GetAll()
                },new DepartmentListModel(){
                    Departments = _departmentService.GetAll()
                }, new List<ApplicationUser>(users)));
        }

        [HttpPost]
        public IActionResult DeleteDepartmentStaff(int departmentId,string userId)
        {
            _departmentStaffService.DeleteDepartmentStaff(departmentId, userId);
            return Redirect("/departmentstaff/listdepartmentstaff/");
        }

        [HttpGet]
        public IActionResult CreateDepartmentStaff()
        {
            var users = _userManager.Users;

            return View(Tuple.Create<DepartmentListModel, List<ApplicationUser>>(new DepartmentListModel()
            {
                Departments = _departmentService.GetAll()
            } , new List<ApplicationUser>(users)));
        }


        [HttpPost]
        public IActionResult CreateDepartmentStaff(int depId, string userId)
        {
            if (ModelState.IsValid)
            {
                var entity = new DepartmentStaff()
                {
                    DepartmentId = depId,
                    UserId = userId
                };

                _departmentStaffService.Create(entity);

                return RedirectToAction("ListDepartmentStaff");
            }

            return View();
        }

    }
}
