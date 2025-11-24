using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class AdminRepository
    {
        private List<Admin> admins;         // internal list storing all admins

        public AdminRepository()
        {
            admins = new List<Admin>();     // initialize the list when the repo is created
        }

        public void AddNewAdmin(Admin admin)       //creating a new admin and adding it to the list
        {
            Admin newAdmin = new Admin(admin.Username, admin.Password, admin.AdminId);
            admins.Add(newAdmin);

        }
        public Admin CreateAdmin(Admin admin)       //creating a new admin and returning it
        {
            Admin newAdmin = new Admin(admin.Username, admin.Password, admin.AdminId);
            return newAdmin;

        }

        public bool RemoveAdmin(int adminId)    //removing an admin from the list by adminId
        {
            Admin? adminToRemove = GetAdminById(adminId);

            if (adminToRemove == null)
            {
                return false;                   //removes admin if found, else returns false
            }
            return admins.Remove(adminToRemove);    //removes admin from list and returns true
        }


        public Admin? GetAdminById(int adminId)
        {
            foreach (Admin admin in admins)
            {
                if (admin.AdminId == adminId)       //goes through the list of admins to find admin by adminId
                {
                    return admin;       //returns the admin if found
                }
            }
            return null;

            
        }
        
        }
}
