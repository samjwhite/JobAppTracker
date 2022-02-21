using JobAppTracker.Models.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class Job : Auditable
    {
        public int ID { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "You cannot leave Title blank.")]
        [StringLength(60, ErrorMessage = "Title cannot be more than 60 characters long.")]
        public string Title { get; set; }

        [Display(Name = "Job Type")]
        [Required(ErrorMessage = "You must select a Job Type")]
        public int JobTypeID { get; set; }
        public JobType JobType { get; set; }

        [Display(Name = "Salary")]
        public decimal? Salary { get; set; }
        [Display(Name = "Hourly Rate")]
        public decimal? HourlyRate { get; set; }
        [Display(Name = "Posted Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DatePosted { get; set; }
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateDue { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "You must select a Job Status")]
        public int StatusID { get; set; }
        public Status Status { get; set; }


        [Display(Name = "Description")]
        [StringLength(2000, ErrorMessage = "Only 5000 characters for description.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Notes")]

        [StringLength(2000, ErrorMessage = "Only 2000 characters for notes.")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [Display(Name = "URL")]
        [Url]
        public string URL { get; set; }

        [Display(Name = "Location")]
        [StringLength(60, ErrorMessage = "Location cannot be more than 30 characters long.")]
        public string Location { get; set; }

        [Display(Name = "Employer Info")]
        public int? EmployerID { get; set; }

        public Employer Employer { get; set; }


    }
}
