using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class Status
    {
        public Status()
        {
            Applications = new HashSet<Application>();
        }
        public int ID { get; set; }
        [Display(Name = "Job Status")]
        [StringLength(20, ErrorMessage = "Job Status can't be longer than 20 symbols")]
        public string Name { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
