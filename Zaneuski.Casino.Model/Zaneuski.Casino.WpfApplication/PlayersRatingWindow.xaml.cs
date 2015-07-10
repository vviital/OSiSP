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
using System.Windows.Shapes;
using Zaneuski.Casino.WcfServiceLibrary;
using Zaneuski.Casino.WpfApplication.Model;
using Zaneuski.Casino.WpfApplication.ServiceReference5;

namespace Zaneuski.Casino.WpfApplication
{
    /// <summary>
    /// Interaction logic for PlayersRatingWindow.xaml
    /// </summary>
    public partial class PlayersRatingWindow : Window
    {
        public PlayersRatingWindow()
        {
            InitializeComponent();
            
            PlayerServiceClient client = new PlayerServiceClient();
            List<PlayerType> players = client.GetAll().ToList();
            List<PlayerResultModel> list = new List<PlayerResultModel>();
            foreach (var player in players)
            {
                list.Add(new PlayerResultModel(player));
            }
            Rating.ItemsSource = list;
        }
    }
}
