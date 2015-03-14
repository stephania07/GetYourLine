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
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Customers.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Models.Customer> All()
        {
            var qu = from Customer in _dbContext.Customers select Customer;
            return qu.ToList<Models.Customer>();
        }

        public int GetCount()
        { 
            return _dbContext.Customers.Count<Models.Customer>();
        }

        public void Add(Models.Customer C)
        {
            _dbContext.Customers.Add(C);
            _dbContext.SaveChanges();
        }
    }
}