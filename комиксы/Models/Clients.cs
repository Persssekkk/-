using System;
using System.Collections.Generic;
using System.Collections;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace комиксы.Models
{
    public partial class Clients
    {
        public long ClientsId { get; set; }
        public string Login { get; set; }
        public BitArray Photo { get; set; }
        public string Nickname { get; set; }
        public long? Orders { get; set; }
        public string Password { get; set; }

        public virtual Order OrdersNavigation { get; set; }
    }
}
