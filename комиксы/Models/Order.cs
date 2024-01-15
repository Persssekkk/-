using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace комиксы.Models
{
    public partial class Order
    {
        public Order()
        {
            Clients = new HashSet<Clients>();
        }

        public long IdOrder { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int? Apartment { get; set; }
        public int? Floor { get; set; }
        public int? Cost { get; set; }
        public string TelNumber { get; set; }
        public long? ProductsId { get; set; }

        public virtual Products Products { get; set; }
        public virtual ICollection<Clients> Clients { get; set; }
    }
}
