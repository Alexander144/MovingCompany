using System;
using System.Collections.Generic;

namespace MovingCompanyAPI.Models
{
    public partial class Person
    {
        public Person()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
