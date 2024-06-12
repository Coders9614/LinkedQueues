using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedQueues.Program;

namespace LinkedQueues
{
    // Includes properties for customer ID, first name, last name,
    // address, and phone number.
    public class Customer
    {
        //get and set allowing them to be read and modified from outside the class.
        public int CustomerId { get; set; }
        public string CustomerFName { get; set; }
        public string CustomerLName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1} {2}, Address: {3}, Phone: {4}", CustomerId, CustomerFName, CustomerLName, Address, PhoneNumber);
        }
    }
}