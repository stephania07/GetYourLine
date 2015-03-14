using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetYourlLine.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Service { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual CustomerDetail CustomerDetails { get; set;}

        public Customer()
        {
        }
        public Customer(string Service, string FirstName, string LastName, string Email, string PhoneNumber)
        {

            this.Service = Service;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;


        }
    }
}