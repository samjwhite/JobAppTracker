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
            Jobs = new HashSet<Job>();
        }
        public int ID { get; set; }
        [Display(Name = "Job Status")]
        [StringLength(20, ErrorMessage = "Job Status can't be longer than 20 symbols")]
        public string Name { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
