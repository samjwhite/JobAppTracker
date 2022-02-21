using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobAppTracker.Models
{
    public class PostingType
    {
        public int TypeID { get; set; }
        public Type Type { get; set; }
        //TODO
        //This may not work. Check for errors
        public int PostingID { get; set; }
        public Posting Posting { get; set; }
    }
}
