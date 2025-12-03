using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GettingRealNorden.ViewModels;
using GettingRealNorden.Views;


namespace GettingRealNorden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm;
        public MainWindow()
        {
            mvm = new MainViewModel();
            InitializeComponent();
            DataContext = mvm;
            btn_Newsletter.IsEnabled = false;
        }

        private void btn_Members_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void btn_Newsletter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_CreateNewsletterDialog_Click(object sender, RoutedEventArgs e)
        {
            mvm.CreateNewsLetter();
            mvm.SaveNewsletters();

            CreateNewsletterDialog createNewsletterDialog = new CreateNewsletterDialog();
            this.Hide(); //Hides MainWindow when btn_CreateNewsletterDialog_Click is initialized
            if (createNewsletterDialog.ShowDialog() == true) //If the Newsletter dialog is closed/false it shows the main window again
            {
                mvm.LoadNewsletters();
                mvm.SelectedNewsletter = mvm.NewsletterVMs[mvm.NewsletterVMs.Count - 1];
                this.Show(); //this refers to the active window/class
                
            }
        }
    }
}