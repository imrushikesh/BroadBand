using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace broadbandAPI.Models
{
    public class accModel
    {

        public int accId { get; set; }

        public int oppId { get; set; }

        public int leadId { get; set; }


        public string accName { get; set; }

        public string accGender { get; set; }
        public string accAddress { get; set; }
        public string accEmail { get; set; }
        public string accPhone { get; set; }
        public string accPlan { get; set; }
        public string accPlanDetails { get; set; }
        public string accPlanPrice { get; set; }
        public string accBilling { get; set; }
        public string accShipping { get; set; }
        public string accCreatedBy { get; set; }
        public string accCreatedOn { get; set; }
        public string leadCreatedBy { get; set; }
        public string leadCreatedOn { get; set; }
        public string oppCreatedBy { get; set; }
        public string oppCreatedOn { get; set; }



    }
}