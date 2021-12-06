using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage ="Job name required")]
        public string Name { get; set; }
        public int EmployerID { get; set; }
        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(string name)
        {
            Name = name;
        }

        public AddJobViewModel(List<Employer> employers)
        {        
            Employers = new List<SelectListItem>();
            foreach (var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
        public AddJobViewModel()
        {
        }

    }
}
