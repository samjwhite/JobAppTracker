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
            Applications = new HashSet<Application>();
            Postings = new HashSet<Posting>();
        }
        //FIELDS
        public int ID { get; set; }
        [Display(Name = "Type")]
        [StringLength(20, ErrorMessage = "Job Type can't be longer than 20 symbols")]
        public string Name { get; set; }
        public ICollection<Application> Applications { get; set; }
        public ICollection<Posting> Postings { get; set; }
    }
}
