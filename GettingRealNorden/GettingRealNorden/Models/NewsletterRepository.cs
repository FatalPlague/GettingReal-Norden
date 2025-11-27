using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class NewsletterRepository : CsvRepository<Newsletter>
    {
        protected override string Filename => "Newsletters.csv"; // CSV file name for newsletters

        protected override Newsletter CreateFromCsv(string[] parts)
        {
            int adminId = int.Parse(parts[1]);             // Parse adminId from CSV
            int newsletterId = int.Parse(parts[2]);       // Parse newsletterId from CSV

            return new Newsletter(parts[0], adminId, newsletterId, parts[3], parts[4], parts[5], parts[6]); //Create and return Newsletter object
        }

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

        public Company GetCompany(string CompanyName, CompanyRepository companyRep, List<Company> companies, Company company)
        {
            return companyRep.GetCompanyByName(company, companies);
        }

        public Admin GetAdmin(int adminId, AdminRepository adminRepo)
        {
            return adminRepo.GetAdminById(adminId);
        }

        public List<Newsletter> GetAll()
        {
            return newsletters;
        }

    }
}
