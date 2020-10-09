using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRM.Business.Abstract;
using CRM.Entities;
using CRM.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebUI.Controllers
{
    public class DepartmentJobController : Controller
    {
        private IDepartmentJobService _departmentJobService;
        private IDepartmentService _departmentService;
        private IJobService _jobService;

        public DepartmentJobController(IDepartmentJobService departmentJobService, IDepartmentService departmentService, IJobService jobService)
        {
            _departmentJobService = departmentJobService;
            _departmentService = departmentService;
            _jobService = jobService;
        }
        public IActionResult ListDepartmentJob()
        {
            return View(Tuple.Create<DepartmentJobModel, DepartmentListModel, JobListModel>
                (new DepartmentJobModel
                {
                    DepartmentJobs = _departmentJobService.GetAll()
                }, new DepartmentListModel()
                {
                    Departments = _departmentService.GetAll()
                }, new JobListModel()
                {
                    Jobs = _jobService.GetAll()
                }));
        }

        [HttpPost]
        public IActionResult DeleteDepartmentJob(int departmentId, int jobId)
        {
            _departmentJobService.DeleteDepartmentJob(departmentId, jobId);
            return Redirect("/departmentjob/listdepartmentjob/");
        }

        [HttpGet]
        public IActionResult CreateDepartmentJob()
        {

            return View(Tuple.Create<DepartmentListModel, JobListModel> (new DepartmentListModel()
            {
                Departments = _departmentService.GetAll()
            }, new JobListModel()
            {
                Jobs = _jobService.GetAll()
            }));
        }


        [HttpPost]
        public IActionResult CreateDepartmentJob(int depId, int jobId)
        {
            if (ModelState.IsValid)
            {
                var entity = new DepartmentJob()
                {
                    DepartmentId = depId,
                    JobId = jobId
                };

                _departmentJobService.Create(entity);

                return RedirectToAction("ListDepartmentJob");
            }

            return View();
        }
    }
}