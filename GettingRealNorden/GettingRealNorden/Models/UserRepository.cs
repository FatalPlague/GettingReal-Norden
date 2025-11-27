using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GettingRealNorden.Models
{
    public class UserRepository : CsvRepository<User>
    {
        protected override string Filename => "Users.csv"; // CSV file name for Users

        protected override User CreateFromCsv(string[] parts)
        {
            bool HasAccess = bool.Parse(parts[2]);             // Parse HasAccess from CSV


            return new User(parts[0], parts[1], HasAccess);      // Create and return User object
        }


        private List<User> users;

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
            string path = "Users.csv";

            try
            {
                if (!File.Exists(path))
                    return; // or throw, depending on what you want

                string[] lines = File.ReadAllLines(path);
                var newLines = new List<string>();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(',');

                    // parts[0] = username, parts[1] = password, parts[2] = hasAccess
                    if (parts.Length > 0 && parts[0] == user.Username)
                    {
                        // Skip this line – effectively removing the user
                        continue;
                    }

                    newLines.Add(line);
                }

                File.WriteAllLines(path, newLines);
            }
            catch (IOException)
            {
                throw; // rethrow or handle as needed
            }
        }

        public void RemoveUser(string username)
        {
            User user = getUser(username);
            Remove(user);



        }
        public UserRepository()
        {
            InitializeRepository();


        }
        
    }
}

