using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class JobType
    {
        public JobType()
        {
            Jobs = new HashSet<Job>();
        }
        //FIELDS
        public int ID { get; set; }
        [Display(Name = "Type")]
        [StringLength(20, ErrorMessage = "Job Type can't be longer than 20 symbols")]
        public string Name { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
