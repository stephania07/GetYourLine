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
        int GetCount();
        void Add(Customer C);
        //void Delete(Customer C);
        void Clear();
    }
}
