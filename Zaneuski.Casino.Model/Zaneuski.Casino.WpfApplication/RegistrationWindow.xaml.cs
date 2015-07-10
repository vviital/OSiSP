using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zaneuski.Casino.Model;
using Zaneuski.Casino.WcfServiceLibrary;
using Zaneuski.Casino.WpfApplication.Model;
using Zaneuski.Casino.WpfApplication.ServiceReference2;
using Zaneuski.Casino.WpfApplication.ServiceReference4;
using Zaneuski.Casino.WpfApplication.ServiceReference5;

namespace Zaneuski.Casino.WpfApplication
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        
        public RegistrationWindow()
        {
            InitializeComponent();
            CountryServiceClient client = new CountryServiceClient();
            List<CountryType> country = client.GetAll().ToList();
            List<string> items = new List<string>();
            foreach (var item in country)
            {
                items.Add(item.CountryName);
            }
            CountryBox.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //PassportInformationServiceClient passport = new PassportInformationServiceClient();
            //PlayerServiceClient player = new PlayerServiceClient();
            //RegistrationModel model = new RegistrationModel();
            //model.Player.Login = Login.ToString();
            //model.Player.Password = Password.ToString();
            //model.Player.FirstName = FirstName.ToString();
            //model.Player.Surname = Surname.ToString();
            //model.Player.Sex = Sex != null && Sex.ToString() == "Male" ? true : false;
            //model.Player.PhoneNumber = PhoneNumber.ToString();
        }
    }
}
