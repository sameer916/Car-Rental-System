using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public double DefaultPrice { get; set; }
        public bool IsAvailable { get; set; }

        public int OwnerId { get; set; }
        public Owner CarOwner { get; set; }

        public int RentalId { get; set; }
        public Rental CarRental { get; set; }

        public int AdminId { get; set; }
        public Admin CarAdmin { get; set; }

    }
}