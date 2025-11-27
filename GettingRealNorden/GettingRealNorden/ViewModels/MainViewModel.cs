using GettingRealNorden.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<NewsletterViewModel> NewsletterVMs;
        public NewsletterViewModel SelectedNewsletter {  get; set; }

        public MainViewModel()
        {
            adminRepo = new AdminRepository();
            companyRepo = new CompanyRepository();
            newsletterRepo = new NewsletterRepository();
            NewsletterVMs = new ObservableCollection<NewsletterViewModel>();

            //test
            newsletterRepo.CreateNewsletter(new Company("Norden", "Danmark", "12345678", "http://googele.dk"), new Admin("Martin", "123456789", 1), "hej", "hej");

            foreach(Newsletter newsletter in newsletterRepo.GetAll())
            {
                NewsletterVMs.Add(new NewsletterViewModel(newsletter));
            }
            SelectedNewsletter = NewsletterVMs[0];
        }

        //public Company GetCompany(string CompanyName)
        //{
        //    return companyRepo.GetCompanyByName(CompanyName);
        //}

        //public Admin GetAdmin(int adminId)
        //{
        //    return adminRepo.GetAdminById(adminId);
        //}

    }


}
