using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace broadbandAPI.Models
{
    public class taskModel
    {
      
      
       public int taskId { get; set; }
        public int empId { get; set; }
        public string taskName { get; set; }
        public string taskAssigned { get; set; }
        public string taskDes { get; set; }
        public string taskStatus { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }
}