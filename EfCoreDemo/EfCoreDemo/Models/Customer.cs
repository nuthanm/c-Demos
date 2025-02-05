﻿using System.Collections.Generic;

namespace EfCoreDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Address { get; set; }

        public string? PostcalCode { get; set; }

        public string? PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
