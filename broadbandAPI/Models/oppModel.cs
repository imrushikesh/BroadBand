using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace broadbandAPI.Models
{
    public class oppModel
    {
        public int oppId { get; set; }
        public int leadId { get; set; }
        public string oppName { get; set; }
        public string oppGender { get; set; }
        public string oppAddress { get; set; }
        public string oppEmail { get; set; }
        public string oppPhone { get; set; }

        public string oppPlan { get; set; }
        public string oppPlanDetails { get; set; }

        public string oppPlanPrice { get; set; }



        public string oppCreatedBy { get; set; }

        public string oppCreatedOn { get; set; }

        public string leadCreatedBy { get; set; }

        public string leadCreatedOn { get; set; }
    }
}