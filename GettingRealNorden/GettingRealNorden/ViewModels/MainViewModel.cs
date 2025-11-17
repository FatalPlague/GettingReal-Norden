using GettingRealNorden.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.ViewModels
{
    public class MainViewModel
    {
        private AdminRepository adminRepo;
        private CompanyRepository companyRepo;
        private NewsletterRepository newsletterRepo;
        public MainViewModel()
        {
            adminRepo = new AdminRepository();
            companyRepo = new CompanyRepository();
            newsletterRepo = new NewsletterRepository();
        }

        public Company GetCompany(string CompanyName)
        {
            return companyRepo.GetCompanyByName(CompanyName);
        }

        public Admin GetAdmin(int adminId)
        {
            return adminRepo.GetAdminById(adminId);
        }
    }


}
