﻿using System.Collections.Generic;

namespace Entity_Framework.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronym { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
