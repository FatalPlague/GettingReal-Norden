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

        public Company GetCompanyByName(string companyName)
        {
            foreach (Company company in companies)
            {
                if (company.Name == companyName)
                {
                    return company;
                }
            }
            return null;
        }

        public static Company GetCompanyById(int id)
        {
            List<Company> temp;
            temp = companies
            foreach (Company company in companies)
            {
                if (company.Name == companyName)
                {
                    return company;
                }
            }
            return null;
        }
    }
}
