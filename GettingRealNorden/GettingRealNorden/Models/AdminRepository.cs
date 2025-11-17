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

        public Admin GetAdminById(int adminId)
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
