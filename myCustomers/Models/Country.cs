using System;
using System.Collections.Generic;

namespace myCustomers
{
    public partial class Country
    {
        public Country()
        {
            Customer = new HashSet<Customer>();
        }

        public string CdCountry { get; set; }
        public string StCountryDescription { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
