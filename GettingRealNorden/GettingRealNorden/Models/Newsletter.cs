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
        private int _newsletterId;
        public int NewsletterId { get { return _newsletterId; } set { _newsletterId = value; } }
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
        private string _companyName;
        public string CompanyName { get { return _companyName; }
            set
            {
                if (value.GetType() != typeof(string))
                {
                    throw new ArgumentException(nameof(value), $"The type must be a string and not {value}");
                }
                _companyName = value;
            }
        }


        private int _adminId;
        public int AdminId { get {return _adminId; } set { _adminId = value;} }
        private string _news;
        
        public string News { get { return _news; } set { _news = value; } }
        
        private string _newslink;
        public string NewsLink { get { return _newslink; } set { _newslink = value; } }
        
        private DateTime _date = DateTime.Now;

        public DateTime Date {
        
            get { return _date; }
            set {
                _date = value;
                }  
        }

        public Newsletter(string companyName, int adminId, int newsletterId, string news, string title, string imagePath, string newsLink)
        {
            CompanyName = companyName;
            AdminId = adminId;
            NewsletterId = newsletterId;
            News = news;
            Title = title;
            ImagePath = imagePath;
            NewsLink = newsLink;
        }

        public Newsletter(string companyName, int adminId, int newsletterId) :
        this(companyName, adminId, newsletterId, "", "", "", "")
        {
        }
    }

}
