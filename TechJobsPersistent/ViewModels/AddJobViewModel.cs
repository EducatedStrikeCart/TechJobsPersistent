using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerID { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public AddJobViewModel()
        {
        }

        public AddJobViewModel(string name, List<Employer> employers)
        {
            Name = name;
            Employers = new List<SelectListItem>();
            foreach (Employer employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
    }
}
