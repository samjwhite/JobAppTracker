using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class Country
    {
        public Country()
        {
            Employers = new HashSet<Employer>();
        }
        public int ID { get; set; }
        [Display(Name = "Name")]
        [StringLength(20, ErrorMessage = "Country Name can't be longer than 20 symbols")]
        public string Name { get; set; }
        public ICollection<Employer> Employers { get; set; }
    }
}
