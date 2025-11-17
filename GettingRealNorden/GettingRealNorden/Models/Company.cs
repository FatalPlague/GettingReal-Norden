using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CVR { get; set; }
        public string WebsiteLink { get; set; }

        public Company(string name, string address, string cvr, string websiteLink)
        {
            Name = name;
            Address = address;
            CVR = cvr;
            WebsiteLink = websiteLink;
        }
    }
}
