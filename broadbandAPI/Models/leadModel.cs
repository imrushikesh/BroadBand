using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace broadbandAPI.Models
{
    public class leadModel
    {
        public int leadId { get; set; }
        public string leadName { get; set; }
        public string leadGender { get; set; }
        public string leadAddress { get; set; }
        public string leadEmail { get; set; }
        public string leadPhone { get; set; }

        public string leadCreatedBy { get; set; }

        public string leadCreatedOn { get; set; }
    }
}