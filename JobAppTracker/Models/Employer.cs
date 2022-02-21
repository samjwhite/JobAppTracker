using JobAppTracker.Models.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class Employer : Auditable
    {
        //CONSTRUCTOR
        public Employer()
        {
            Jobs = new HashSet<Job>();     
        }

        //PROPERTIES
        [Display(Name = "Number of Jobs")]
        public int NumberOfJObs
        {
            get
            {
                int count = 0;

                foreach (Job j in Jobs) count++;

                return count;
            }
        }
        //FIELDS
        public int ID { get; set; }
        [Display(Name = "Alias")]
        [StringLength(20, ErrorMessage = "Alias can't be longer than 20 symbols")]
        public string Alias { get; set; }
        [Display(Name = "Employer")]
        [StringLength(20, ErrorMessage = "Employer Name can't be longer than 20 symbols")]
        public string Name { get; set; }
        [Display(Name = "URL")]
        [Url]
        public string URL { get; set; }
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Phone")]
        [Phone]
        public string Phone { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "You must select a Country")]
        public int? CountryID { get; set; }
        public Country Country { get; set; }

        [Display(Name = "Province")]
        [StringLength(20, ErrorMessage ="Province can't be longer than 50 symbols")]
        public string Province { get; set; }

        [Display(Name = "Street Number")]
        [Required(ErrorMessage = "You cannot leave the Street Number blank.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Street number must be numeric")]
        public string StreetNumber { get; set; }

        [Display(Name = "Street Name")]
        [Required(ErrorMessage = "You can not leave the Street Name blank")]
        [StringLength(100)]
        public string StreetName { get; set; }

        [Display(Name = "City")]
        [StringLength(100, ErrorMessage = "City name can't be longer than 50 symbols")]
        public string City { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(10, ErrorMessage = "Postal Code can't be longer than 10 symbols")]
        public string PostalCode { get; set; }













        public ICollection<Job> Jobs { get; set; }
    }
}
