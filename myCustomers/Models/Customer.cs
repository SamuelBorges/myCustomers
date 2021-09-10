using System;
using System.Collections.Generic;

namespace myCustomers
{
    public partial class Customer
    {
        public int CdCustomer { get; set; }
        public string StName { get; set; }
        public string StOperation { get; set; }
        public string StCnpj { get; set; }
        public int? ItAmount { get; set; }
        public decimal? DcBilling { get; set; }
        public string StPhone { get; set; }
        public string StMobile { get; set; }
        public string StAddress { get; set; }
        public string StDistrict { get; set; }
        public string StCity { get; set; }
        public string CdCountry { get; set; }
        public string StZipCode { get; set; }

        public virtual Country CdCountryNavigation { get; set; }
    }
}
