using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace комиксы.Models
{
    public partial class Cart
    {
        public long? ClientsId { get; set; }
        public long? ProductsId { get; set; }
        public long CartId { get; set; }

        public virtual Clients Clients { get; set; }
        public virtual Products Products { get; set; }
    }
}
