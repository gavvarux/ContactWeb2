using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class ContactWeb
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string phone2 { get; set; }
        public DateTime dob { get; set; }
        public string streetadd { get; set; }
        public string streetadd2 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string postcode { get; set; }
    }
}