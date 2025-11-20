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
using GettingRealNorden.Views;

namespace GettingRealNorden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
            CreateNewsletterDialog createNewsletterDialog = new CreateNewsletterDialog();
            this.Hide(); //Hides MainWindow when btn_CreateNewsletterDialog_Click is initialized
            if (createNewsletterDialog.ShowDialog() == false) //If the Newsletter dialog is closed/false it shows the main window again
            {
                this.Show(); //this refers to the active window/class
                
            }
        }
    }
}