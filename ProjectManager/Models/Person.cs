using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Models {
    public class Person {
        // A lot of values are enum candidates. 
        public int ID { get; set; }
        // e.g. Prof, Dr, VC
        // either check if title is prefix or suffix or make two fields
        public string Title { get; set; }
        public string Religion { get; set; }
        public string Ethnicity { get; set; }
        public string Nationality { get; set; }
        public string Sex { get; set; }
        public string Prename { get; set; }
        public string Surname { get; set; }
        // parsing required
        // better make a hash out of it to allow infinte numbers with description.
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
        // Optional: validate the address for plausability
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public string AppartementNumber { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
    }
}