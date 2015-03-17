using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetYourlLine.Models
{
    public class CustomerDetail
    {
        public int CustomerDetailID { get; set; }
        public int CustomerID { get; set; }

        [Display(Name = "CurrentTime")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0}", ApplyFormatInEditMode = true)]
        public DateTime CurrentTime { get; set; } // indicates the current time prefer Noda time
        
        public DateTime RegisteredTime { get; set; } // indicates the registered time of the customer
        public int EstimatedMinutes { get; set;} // calculated amount of time the customer to wait     
        public int CustomersNumber { get; set; } // this calculates the number of customers ahead of him/her

        public virtual Customer Customer { get; set; }

        public CustomerDetail()
        {

        }

        public CustomerDetail (DateTime CurrentTime, DateTime RegisteredTime, int EstimatedMinutes, int CustomersNumber) 
        {
            this.CurrentTime = CurrentTime;
            this.RegisteredTime = RegisteredTime;
            this.EstimatedMinutes = EstimatedMinutes;
            this.CustomersNumber = CustomersNumber;

            //DateTime.Now.ToString("HH:mm:ss tt");
        }

    }
}