using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class User
    {
        private string _username;
        public string Username        
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;
        public string Password
        {
            get { return _username; }
            set { _password = value; }

        }
        private bool _hasAcess = false;
        public bool HasAces
        {
            get { return _hasAcess; }
            set {
                _hasAcess = value; 

            }

        }
        public User(string username, string password, bool hasAces)
        {
            Username = username;
            Password=  password;
            HasAces = hasAces;
        }
        public bool NoAcessMore(User user)
        {
            return user.HasAces= false;
        }
        public bool AcessNow(User user)
        {
            return user.HasAces = true;
        }

    }
}
