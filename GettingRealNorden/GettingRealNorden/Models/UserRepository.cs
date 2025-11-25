using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GettingRealNorden.Models
{
    public class UserRepository
    {
        private List<User> users;
        private void InitializeRepository()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Users.csv"))
                {
                    // Read the stream to a string, and instantiate a Person object
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] parts = line.Split(',');

                        // parts[0] contains first name, parts[1] contains last name, parts[2] contains age as text, parts[3] contains phone

                        this.Add(parts[0], parts[1], bool.Parse(parts[2]));

                        //Read the next line
                        line = sr.ReadLine();
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
        }
        public User Add(string username, string password, bool Truevalue)
        {
            User result = null;

            if (!string.IsNullOrEmpty(username) &&
                !string.IsNullOrEmpty(password) &&
                password.Length >= 0 &&
                password.Length >= 8)

            {
                result = new User()
                {
                    Username = username,
                    Password = password,
                    HasAccess = Truevalue,


                };

                // Add to persons list
                users.Add(result);
            }
            else
                throw (new ArgumentException("Not all arguments are valid"));

            return result;
        }
        public User? getUser(string username)
        {


            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }
            return null;

        }

        public bool getBoolStatus(string username)
        {
            User user = getUser(username);

            return user.HasAccess;
        }

        public void setHasValueToTrue(string username)
        {
            User user = getUser(username);
            user.HasAccess = true;

        }
        public void setHasVlaueToFaluse(string username)
        {
            User user = getUser(username);
            user.HasAccess = false;
        }
        public void Remove(User user)
        {

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Users.csv"))
                {
                    // Read the stream to a string, and instantiate a Person object
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] parts = line.Split(',');

                        // parts[0] contains first name, parts[1] contains last name, parts[2] contains age as text, parts[3] contains phone
                        if (parts[0] == user.Username)
                        {
                            parts[0] = "";
                            parts[1] = "";
                            parts[2] = "";
                        }



                        //Read the next line
                        line = sr.ReadLine();
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void RemoveUser(string username)
        {
            User user = getUser(username);
            Remove(user);



        }

    }
}

