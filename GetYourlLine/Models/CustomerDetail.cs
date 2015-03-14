using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetYourlLine.Models
{
    public class CustomerDetail
    {
        public int CustomerDetailID { get; set; }
        public int CustomerID { get; set; }
        public string DateTime { get; set; }
        public string RegisteredTime { get; set; }
        public string Status { get; set; }

        //public virtual Customer Customer { get; set; }

        public CustomerDetail()
        {

        }
    }
}