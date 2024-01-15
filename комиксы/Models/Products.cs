using System;
using System.Collections.Generic;
using System.Collections;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace комиксы.Models
{
    public partial class Products
    {
        public Products()
        {
            Order = new HashSet<Order>();
        }

        public long IdProducts { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public BitArray Photo { get; set; }
        public int? Price { get; set; }
        public int? Amount { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
