using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GetYourlLine.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Service { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
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