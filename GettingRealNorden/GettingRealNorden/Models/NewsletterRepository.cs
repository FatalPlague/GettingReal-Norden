using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class NewsletterRepository
    {
        private List<Newsletter> newsletters;

        public NewsletterRepository()
        {
            newsletters = new List<Newsletter>();
        }

        public int Count()
        {
            return newsletters.Count;
        }

        public int CreateNewsletter(Company company, Admin admin)
        {
            int id = Count() + 1;
            newsletters.Add(new Newsletter(company.Name, admin.AdminId, id));
            return id;
            
        }

        public Company? GetCompany(string CompanyName, CompanyRepository companyRep, List<Company> companies, Company company)
        {
            return companyRep.GetCompanyByName(company, companies);
        }

        public Admin? GetAdmin(int adminId, AdminRepository adminRepo)
        {
            return adminRepo.GetAdminById(adminId);
        }

    }
}
