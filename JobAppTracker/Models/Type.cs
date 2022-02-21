using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class Type
    {
        public Type()
        {
            JobTypes = new HashSet<JobType>();
            //TODO
            //Will it work?
            PostingTypes = new HashSet<PostingType>();
            
        }
        //FIELDS
        public int ID { get; set; }
        [Display(Name = "Type")]
        [StringLength(20, ErrorMessage = "Job Type can't be longer than 20 symbols")]
        public string Name { get; set; }

        //TODO 
        //Check this field naming
        [Display(Name = "Job Types")]
        public ICollection<JobType> JobTypes { get; set; }
        public ICollection<PostingType> PostingTypes { get; set; }
    }
}
