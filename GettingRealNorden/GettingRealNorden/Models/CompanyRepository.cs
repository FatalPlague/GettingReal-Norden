using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class CompanyRepository
    {
        private List<Company> companies = new List<Company>();

        public CompanyRepository()
        {
            companies = new List<Company>();
        }

        public String? GetCompanysName(string companyName)
        {
            foreach (Company company in companies)
            {
                if (company.Name == companyName)
                {
                    return company.Name;
                }
            }
            return null;
        }

        public Company GetCompanyByName(Company givencompany, List<Company> companies)
        {
            String companyName = GetCompanysName(givencompany.Name);
            
            foreach (Company company in companies)
            {
                if (companyName == givencompany.Name)
                {
                    return company;
                }
            }
            return null;
        }
    }
}
