using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalSystem.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }

        public List<Car> OwnerCarList { get; set; }
        public int AdminId { get; set; }
        public Admin OwnerAdmin { get; set; }
    }
}