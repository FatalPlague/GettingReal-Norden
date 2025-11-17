using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class Admin
    {
        public int AdminId {  get; set; }
        private string username;
        private string password;

        public Admin(string username, string password, int adminId)
        {
            this.username = username;
            this.password = password;
            AdminId = adminId;
        }
    }
}
