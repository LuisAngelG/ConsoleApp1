using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCustomer
    {

        public List<Customer> GetByName(string Name)
        {

            List<Customer> customer = new List<Customer>();

            DCustomer dCustomer = new DCustomer();
            customer = dCustomer.GetCustomer();

            var results = customer.Where(x => x.Name.Contains(Name)).ToList();

            return results;
        }

    }
}
