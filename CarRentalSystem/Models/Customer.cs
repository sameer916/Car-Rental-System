using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }

        public int RentalId { get; set; }
        public Rental CustomerRental { get; set; }

        public int AdminId { get; set; }
        public Admin CustomerAdmin { get; set; }
    }
}