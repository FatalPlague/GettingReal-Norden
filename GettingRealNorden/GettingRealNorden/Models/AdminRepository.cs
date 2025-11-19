using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class AdminRepository
    {
        private List<Admin> admins;

        public AdminRepository()
        {
            admins = new List<Admin>();
        }

        public void AddNewAdmin(Admin admin)
        {
            Admin newAdmin = new Admin(admin.Username, admin.Password, admin.AdminId);
            admins.Add(newAdmin);
            
        }
        public Admin CreateAdmin(Admin admin)
        {
            Admin newAdmin = new Admin(admin.Username, admin.Password, admin.AdminId);
            return newAdmin;

        }


        public Admin? GetAdminById(int adminId)
        {
            foreach (Admin admin in admins)
            {
                if (admin.AdminId == adminId)
                {
                    return admin;
                }
            }
            return null;
        }
    }
}
