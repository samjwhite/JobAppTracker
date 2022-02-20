using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models.Interfaces
{
    internal interface IAuditable
    {
        string CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
    }
}
