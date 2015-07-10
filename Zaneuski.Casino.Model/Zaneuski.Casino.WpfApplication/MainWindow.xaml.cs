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
using Zaneuski.Casino.WcfServiceLibrary;
using Zaneuski.Casino.WpfApplication.Model;
using Zaneuski.Casino.WpfApplication.ServiceReference9;

namespace Zaneuski.Casino.WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TournamentServiceClient client = new TournamentServiceClient();
            List<TournamentType> tournaments = client.GetAll().ToList();
            List<TournamentsModel> tournamentsModels = new List<TournamentsModel>();
            foreach (var item in tournaments)
            {
                tournamentsModels.Add(new TournamentsModel(item));
            }
            TournamentsView.ItemsSource = tournamentsModels;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrationWindow window = new RegistrationWindow();
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PlayersRatingWindow ratingWindow = new PlayersRatingWindow();
            ratingWindow.Show();
        }
    }
}
