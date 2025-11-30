using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public class NewsletterRepository : IRepository
    {
        public string FileName { get; }
        private List<Newsletter> newsletters;

        public NewsletterRepository(string fileName)
        {
            FileName = fileName;
            newsletters = new List<Newsletter>();
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

                        Newsletter newsletter = new Newsletter(
                            stringArr[0],
                            int.Parse(stringArr[1]),
                            int.Parse(stringArr[2]),
                            stringArr[3],
                            stringArr[4],
                            stringArr[5],
                            stringArr[6]);

                        newsletters.Add(newsletter);
                    }
                }
            }
            catch
            {
                throw new ArgumentException("Something went wrong");
            }
        }

        public void SaveNewsletters()
        {
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                foreach (Newsletter newsletter in newsletters)
                {
                    sw.WriteLine(newsletter.ToString());
                }

            }
        }

        public void LoadNewsletters()
        {
            newsletters.Clear();
            InitializeRepo();
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

        public Company GetCompany(string ompanyName, CompanyRepository companyRepo, List<Company> companies, Company company)
        {
            return companyRepo.GetCompanyByName(company, companies);
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
