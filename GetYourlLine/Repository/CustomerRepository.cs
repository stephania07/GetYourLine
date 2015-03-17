using GetYourlLine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GetYourlLine;

namespace GetYourlLine.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerContext _dbContext;

        public CustomerRepository(string connetion = "GetYourlLine.Models.CustomerContext") 
        {
            _dbContext = new CustomerContext();
            _dbContext.Customers.Load();
            _dbContext.CustomerDetails.Load();
        }

        public void Clear()
        {
            var a = this.GetAllCustomers();
            _dbContext.Customers.RemoveRange(a);
            var b = this.GetAllCustomerDetails();
            _dbContext.CustomerDetails.RemoveRange(b);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Models.Customer> GetAllCustomers()
        {
            var qu = from Customer in _dbContext.Customers select Customer;
            return qu.ToList<Models.Customer>();
        }

        public IEnumerable<Models.CustomerDetail> GetAllCustomerDetails()
        {
            var qu = from CustomerDetail in _dbContext.CustomerDetails select CustomerDetail;
            return qu.ToList<Models.CustomerDetail>();
        }

        public int GetCountCustomers()
        { 
            return _dbContext.Customers.Count<Models.Customer>();
        }

        public int GetCountCustomerDetails()
        {      
            return _dbContext.CustomerDetails.Count<Models.CustomerDetail>();
        }


        public void AddCustomers(Models.Customer C)
        {
            _dbContext.Customers.Add(C);
            _dbContext.SaveChanges();
        }

        public void AddCustomerDetails(Models.CustomerDetail D)
        {
            _dbContext.CustomerDetails.Add(D);
            _dbContext.SaveChanges();
        }

        public void DeleteCustomer(Models.Customer C)
        {
            _dbContext.Customers.Remove(C);
            _dbContext.SaveChanges();
        }

        public void DeleteCustomerDetails(Models.CustomerDetail D)
        {
            _dbContext.CustomerDetails.Remove(D);
            _dbContext.SaveChanges();
        }
       
    }
}