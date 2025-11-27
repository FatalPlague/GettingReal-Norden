using GettingRealNorden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.ViewModels
{
    public class NewsletterViewModel
    {
        private Newsletter newsletter;

        public int NewsletterId { get { return newsletter.NewsletterId; } set { newsletter.NewsletterId = value; } }

        public string Title { get { return newsletter.Title; } set { newsletter.Title = value; } }

        public string ImagePath { get { return newsletter.ImagePath; } set { newsletter.ImagePath = value; } }

        public string NewsLink { get { return newsletter.NewsLink; } set { newsletter.NewsLink = value; } }

        public DateTime Date { get { return newsletter.Date; } set { newsletter.Date = value; } }
        public string News { get { return newsletter.News; } set { newsletter.News = value; } }

        public NewsletterViewModel(Newsletter newsletter)
        {
            this.newsletter = newsletter;
        }



    }
}
