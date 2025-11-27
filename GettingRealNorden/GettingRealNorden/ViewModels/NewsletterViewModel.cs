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

        public int NewsletterId { get; set; }

        public string Title { get; set; }

        public string ImagePath { get; set; }

        public string HyperLink {  get; set; }

        public DateTime Date {  get; set; }

        public NewsletterViewModel(Newsletter newsletter)
        {
            this.newsletter = newsletter;
        }



    }
}
