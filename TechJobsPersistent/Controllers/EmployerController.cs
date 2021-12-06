using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;
        public EmployerController(JobDbContext jobDbContext)
        {
            context = jobDbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> allEmployers = context.Employers.ToList();
            return View(allEmployers);
        }

        public IActionResult Add(AddEmployerViewModel addEmployerViewModel)
        {
            return View(addEmployerViewModel);
        }
        [HttpPost]
        [Route("Employer/Add")]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer()
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };

                context.Employers.Add(newEmployer);
                context.SaveChanges();

                return Redirect("Index");
            }

            return View("Add");
        }

        public IActionResult About(int id)
        {
            List<Employer> allEmployers = context.Employers.Where(e => e.Id == id).ToList();
            return View(allEmployers);
        }
    }
}
