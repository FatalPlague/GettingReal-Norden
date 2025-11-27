using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GettingRealNorden.Models
{
    public class Newsletter
    {
        private int _newletterId;
        public int NewsletterId { get { return _newletterId; } set { _newletterId = value; } }
        private string _title;
        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set {_ImagePath = value; }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                if (value.GetType() != typeof(string))
                {
                    throw new ArgumentException(nameof(value), $"The type must be a string and not {value}");
                }
                _title = value;
            }

        }
        private string _companyname;
        public string CompanyName { get { return _companyname; }
            set
            {
                if (value.GetType() != typeof(string))
                {
                    throw new ArgumentException(nameof(value), $"The type must be a string and not {value}");
                }
                _companyname = value;
            }
        }


        private int _adminId;
        public int AdminId { get {return _adminId; } set { _adminId = value;} }
        private string _news;
        
        public string News { get { return _news; } set { _news = value; } }
        
        private string _newslink;
        public string NewsLink { get { return _newslink; } set { _newslink = value; } }
        
        private DateTime _date;

        public DateTime Date {
        
            get { return _date; }
            set {
                _date = value;
                }  
        }

        public Newsletter(string companyName, int adminId, int newsletterId)
        {
            NewsletterId = _newletterId;
            Title = "Hej";
            Date = DateTime.Now;
            CompanyName = companyName;
            News = "Indtast nyhed her";
            AdminId = adminId;
        }
    }

}
