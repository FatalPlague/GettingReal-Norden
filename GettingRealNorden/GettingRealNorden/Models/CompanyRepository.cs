using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class CompanyRepository : IRepository
    {
        public string FileName { get; }
        private List<Company> companies;

        public CompanyRepository(string fileName)
        {
            FileName = fileName;
            companies = new List<Company>();
            InitializeRepo();

        }

        public void InitializeRepo()
        {
            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] stringArr = sr.ReadLine().Split(";");

                        Company company = new Company(
                            stringArr[0],
                            stringArr[1],
                            stringArr[2],
                            stringArr[3]);

                        companies.Add(company);
                    }
                }
            }
            catch
            {
                throw new ArgumentException("Something went wrong");
            }

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
