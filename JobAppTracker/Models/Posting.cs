using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class Posting
    {
        public Posting()
        {
            PostingTypes = new HashSet<PostingType>();

        }
        //TODO
        //Posting can be transformed into Application 
        //Use Fields to prepopulate Application
        //Remove Posting after transref 
        public int ID { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "You cannot leave Title blank.")]
        [StringLength(60, ErrorMessage = "Title cannot be more than 60 characters long.")]
        public string Title { get; set; }
        [Display(Name = "Salary")]
        public decimal? Salary { get; set; }
        [Display(Name = "Hourly Rate")]
        public decimal? HourlyRate { get; set; }

        [Display(Name = "Posting Type")]
        public ICollection<PostingType> PostingTypes { get; set; }
        public JobType JobType { get; set; }
        [Display(Name = "URL")]
        [Url]
        public int URL { get; set; }

    }
}
