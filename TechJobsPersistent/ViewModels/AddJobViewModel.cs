using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public string EmployerID { get; set; }
        public List<Employer> SelectListItem { get; set; }
    }
}
