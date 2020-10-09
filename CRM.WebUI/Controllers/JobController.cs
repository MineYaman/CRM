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
    [Authorize(Roles = "customer")]
    public class JobController : Controller
    {
        private IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        public IActionResult ListJob()
        {
            return View(new JobListModel()
            {
                Jobs = _jobService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult CreateJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateJob(JobModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Job()
                {
                    Name = model.Name,
                    Descripton = model.Descripton,
                    StartDate = model.StartDate,
                    DateCompleted = model.DateCompleted
                };

                _jobService.Create(entity);

                return RedirectToAction("ListJob");
            }

            return View(model);
        }
    }
}