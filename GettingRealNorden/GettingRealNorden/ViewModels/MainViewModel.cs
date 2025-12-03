using GettingRealNorden.Commands;
using GettingRealNorden.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GettingRealNorden.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private AdminRepository adminRepo;
        private CompanyRepository companyRepo;
        private NewsletterRepository newsletterRepo;
        public ObservableCollection<NewsletterViewModel> NewsletterVMs;

        private NewsletterViewModel selectedNewsletter;
        public NewsletterViewModel SelectedNewsletter
        {
            get { return selectedNewsletter; }
            set
            {
                selectedNewsletter = value;
                OnPropertyChanged("SelectedNewsletter");
                //selectedNewsletter = value;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand SaveNewsletterCommand { get; } = new SaveNewsletterCommand();

        //public ICommand CreateNewNewsletterCommand { get; } = new CreateNewNewsletterCommand(); Er flyttet til code behind, da command blev udført efter knap tryk i codebehind.

        public MainViewModel()
        {
            adminRepo = new AdminRepository("Resources/Admins.csv");
            companyRepo = new CompanyRepository("Resources/Companies.csv");
            newsletterRepo = new NewsletterRepository("Resources/Newsletters.csv");
            
            NewsletterVMs = new ObservableCollection<NewsletterViewModel>();

            foreach(Newsletter newsletter in newsletterRepo.GetAll())
            {
                NewsletterVMs.Add(new NewsletterViewModel(newsletter));
            }
            if (NewsletterVMs.Count > 0)
                SelectedNewsletter = NewsletterVMs[NewsletterVMs.Count -1];
        }

        public void SaveNewsletters()
        {
            newsletterRepo.SaveNewsletters();
        }
        public void LoadNewsletters()
        {
            newsletterRepo.InitializeRepo();
            NewsletterVMs.Clear();
            foreach (Newsletter newsletter in newsletterRepo.GetAll())
            {
                NewsletterVMs.Add(new NewsletterViewModel(newsletter));
            }
            SelectedNewsletter = NewsletterVMs[0];
        }

        public void CreateNewsLetter()
        {
            newsletterRepo.CreateNewsletter(new Company("Norden", "Danmark", "12345678", "http://Norden-odense.dk"), new Admin("Andreas", "123456789", 1));
        }

        //public Company GetCompany(string CompanyName)
        //{
        //    return companyRepo.GetCompanyByName(CompanyName);
        //}

        //public Admin GetAdmin(int adminId)
        //{
        //    return adminRepo.GetAdminById(adminId);
        //}

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
                => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }


}
