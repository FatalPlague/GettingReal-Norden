using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class Admin
    {
        private int _addminId;
        public int AdminId { get { 
                
                return _addminId; }  set
            {
                if(value.GetType() != typeof(int))
                {
                    throw new ArgumentException(nameof(value), $"The type must be a int and not {value}");
                }
                _addminId = value;
            }
            
            
            }
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.GetType() != typeof(string))
                {
                    throw new ArgumentException(nameof(value), $"The type must be a string and not {value}");
                }
                _username = value;
                // To check if the username of the type of string and not other types
            }
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.GetType() != typeof(string))
                {
                    throw new ArgumentException(nameof(value), $"The must be a string and not {value}");
                }
                // To check if the username of the type of string and not other types
                if (value.Length < 8)
                {
                    throw new ArgumentException(nameof(value), $"The Password must be a least 8 long {value.Length}");
                }
                // To check if the username have the length of a least 8
                _password = value;
            }
        }



        private string password;

        public Admin(string username, string password, int adminId)
        {
            Username = username;
            Password = password;
            AdminId = adminId;
        }
    }
}
