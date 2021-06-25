using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public List<Customer> AdminCustomerList { get; set; }
        public List<Owner> AdminOwnerList { get; set; }
        public List<Car> AdminCarList { get; set; }
        public List<Rental> AdminRentalList { get; set; }
    }
}