using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class Company
        
    {
        private string _name;
        //Backingfield for name
        private string _address;
        //Backingfield for address
        private string _cvr;
        //Backingfield for CVR number
        private string _url;
        //Backingfield for company URL

        public string Name { get { return _name; } set { if (value.GetType() != typeof(string))
                {
                    throw new ArgumentException(nameof(value), $"The type must be a string and not {value}");
                }
                _name = value;
                    } 
                    
        }
        //The property of "Name" is set, if the value is string. Otherwise an exception is thrown.
        public string Address { get { return _address; } set {
                if (!char.IsLetter(value[0]))
                {
                    throw new ArgumentException(nameof(value), $"The Address: {value} must start with at letter");
                }
                _address = value;} }
        //The property of "address" is set, if the value is string. Otherwise an exception is thrown.

        public string CVR { get {return _cvr;} set { if (value.Length != 8)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"CVR needs to be exactly 8 digits and not {value}");
                }
                int i = 0;
                char c;
                while (value[i] != 0)
                {
                    c = (value[i]);
                    bool charDigit = char.IsDigit(c);
                    if(charDigit ==  false)
                    {
                        throw new ArgumentException(nameof(value), $"The CVR: {value} must be digits");
                    }
                    
                    i++;
                }
                /* The loop goes through all characters in the string, and if the characters are digits, CVR is set. If the characters are
                not digits, an exception is thrown. */

                _cvr = value;
            } }
        //The property of "CVR" is set, if the string length is 8, and are digits. Otherwise an exception is thrown.

        public string WebsiteLink { get { return _url; } set
            {
                if (value.GetType() != typeof(string))
                {
                    throw new ArgumentException(nameof(value), $"The given url: {value} is invaild ");
                }
                _url = value;
            }
        }

        //The property of "URL" is set, if the value is string. Otherwise an exception is thrown.





        public Company(string name, string address, string cvr, string websiteLink)
        {
            Name = name;
            Address = address;
            CVR = cvr;
            WebsiteLink = websiteLink;
        }
    }
}
