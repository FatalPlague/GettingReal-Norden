using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class CompanyRepository : CsvRepository<Company>
    {

        protected override string Filename => "Companies.csv"; // CSV file name for admins

        protected override Company CreateFromCsv(string[] parts)
        {

            return new Company(parts[0], parts[1], parts[2], parts[3]); // Create and return Company object

        }


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
