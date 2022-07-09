using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_Projekt
{
    /// <summary>
    /// Interaction logic for PlayerDetails.xaml
    /// </summary>
    public partial class PlayerDetails : Window
    {
        private Match match;
        private PlayerTile playerTile;
        Player player;
        ApiHelper apiHelper = new ApiHelper();
        BackgroundWorker bkgWorker;
        int goals;
        int yellow;
        public string PlayerName { get; set; }

        public PlayerDetails()
        {
            InitializeComponent();
            InitBackGroundWorker();
        }
        private void InitBackGroundWorker()
        {
            this.bkgWorker = new BackgroundWorker();
            this.bkgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            this.bkgWorker.DoWork += new DoWorkEventHandler(worker_DoWork);

        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            player = FindPlayerByName(playerTile.PlayerName);
            goals = apiHelper.GetGoalsByMatch(match, player);
            yellow = apiHelper.GetYellowCardsByMatch(match, player);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblName.Text = playerTile.PlayerName;
            lblPlayerNumber.Text = playerTile.PlayerNumber;
            lblPosition.Text = player.Position.ToString();
            lblGoals.Text = player.Goals.ToString();
            lblYellowCards.Text = player.YellowCards.ToString();
            lblGoals.Text = goals.ToString();
            lblYellowCards.Text = yellow.ToString();
            lblKapetan.Visibility = player.Captain ? Visibility.Visible : Visibility.Hidden;
        }

        public PlayerDetails(Match match, PlayerTile playerTile) : this()
        {
            this.match = match;
            this.playerTile = playerTile;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bkgWorker.RunWorkerAsync(); 
        }

        private Player FindPlayerByName(string playerName)
        {
            List<Player> AllPlayers = match.HomeTeamStatistics.StartingEleven.Union(match.AwayTeamStatistics.StartingEleven).ToList();
            return AllPlayers.Find(p => p.Name == playerName);
        }
    }
}
