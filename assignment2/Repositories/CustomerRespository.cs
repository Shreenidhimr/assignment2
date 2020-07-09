using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Entities;
namespace assignment2.Repositories
{
    public class CustomerRespository
    {
        public CustomerContext db = new CustomerContext();

        public List<Customer> GetCustomers()
        {
            return db.Customer.ToList();
        }
        public Customer GetCustomerById(String Cid)
        {
            return db.Customer.Find(Cid);
        }
        public void Add(Customer c)
        {
            db.Customer.Add(c);
            db.SaveChanges();
        }
        public void Delete(Customer c)
        {
            db.Customer.Remove(c);
            db.SaveChanges();

        }
        public void Update(Customer c)
        {
            db.Customer.Update(c);
            db.SaveChanges();
        }

    }
}
