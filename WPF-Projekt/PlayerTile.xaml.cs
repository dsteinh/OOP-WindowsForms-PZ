using DataLayer;
using DataLayer.Model;
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

namespace WPF_Projekt
{
    /// <summary>
    /// Interaction logic for PlayerTile.xaml
    /// </summary>
    public partial class PlayerTile : UserControl
    {
        public static Match match;

        ApiHelper apiHelper = new ApiHelper();
        public string PlayerNumber { get; set; }
        public string PlayerName { get; set; }
        public PlayerTile()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lblName.Text = PlayerName;
            lblPlayerNumber.Text = PlayerNumber;
            
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PlayerDetails playerDetails = new PlayerDetails(match, this);
            playerDetails.Show();
        }
    }
}
