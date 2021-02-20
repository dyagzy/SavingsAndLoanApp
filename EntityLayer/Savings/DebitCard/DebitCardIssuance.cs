using EntityLayer.CustomerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
   public class DebitCardIssuance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateTime { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string Cvv { get; set; }


    //navigation property
    public IEnumerable<CustomerProfile> CustomerProfiles { get; set; }
  }
}

