using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetYourlLine.Models;

namespace GetYourlLine.Repository
{
    public interface ICustomerRepository
    {
        int GetCountCustomers();
        int GetCountCustomerDetails();
        void AddCustomers(Customer C);
        void AddCustomerDetails(CustomerDetail D);
        void DeleteCustomer(Customer C);
        void DeleteCustomerDetails(CustomerDetail D);
        void Clear();
       // void GetCustomerNumber();
    }
}
