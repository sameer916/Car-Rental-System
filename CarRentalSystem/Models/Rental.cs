using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public double FairAmount { get; set; }
        public string InitialFuel { get; set; }

        public List<Car> RentalCarList { get; set; }
        public List<Customer> RentalCustomerList { get; set; }

        public int AdminId { get; set; }
        public Admin RentalAdmin { get; set; }
    }
}