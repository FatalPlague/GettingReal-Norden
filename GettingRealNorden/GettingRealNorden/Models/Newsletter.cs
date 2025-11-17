using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class Newsletter
    {
        public int NewsletterId { get;}
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string CompanyName { get; }
        public int AdminId { get; }
        public List<string> News {  get; set; }
        public List<string> NewsLinks { get; set; }

        public Newsletter(string companyName, int adminId, int newsletterId)
        {
            NewsletterId = newsletterId;
            Title = "";
            Date = DateTime.Now;
            CompanyName = companyName;
            AdminId = adminId;
            News = new List<string>();
            NewsLinks = new List<string>();
        }
    }

}
