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
    /// Interaction logic for PlayerPositions.xaml
    /// </summary>
    public partial class PlayerPositions : Window
    {
        ApiHelper apiHelper = new ApiHelper();
        private Team fteam;
        private Team oteam;
        Match match;
        BackgroundWorker bkgWorker;
        public PlayerPositions()
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
            match = apiHelper.GetMatchByTeams(fteam, oteam);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<Player> homePlayers = match.HomeTeamStatistics.StartingEleven;
            List<Player> awayPlayers = match.AwayTeamStatistics.StartingEleven;

            PlayerTile.match = match;

            foreach (Player hp in homePlayers)
            {
                PlayerTile pt = new PlayerTile
                {
                    PlayerName = hp.Name,
                    PlayerNumber = hp.ShirtNumber,

                };

                switch (hp.Position)
                {
                    case Position.Defender:
                        ht2.Children.Add(pt);
                        break;
                    case Position.Forward:
                        ht4.Children.Add(pt);
                        break;
                    case Position.Goalie:
                        ht1.Children.Add(pt);
                        break;
                    case Position.Midfield:
                        ht3.Children.Add(pt);
                        break;
                }
            }

            foreach (Player ap in awayPlayers)
            {
                PlayerTile pt = new PlayerTile
                {
                    PlayerName = ap.Name,
                    PlayerNumber = ap.ShirtNumber,
                };

                switch (ap.Position)
                {
                    case Position.Defender:
                        at2.Children.Add(pt);
                        break;
                    case Position.Forward:
                        at4.Children.Add(pt);
                        break;
                    case Position.Goalie:
                        at1.Children.Add(pt);
                        break;
                    case Position.Midfield:
                        at3.Children.Add(pt);
                        break;
                }
                Cursor = Cursors.Arrow;
            }
        }

        public PlayerPositions(Team fteam, Team oteam) : this()
        {
            this.fteam = fteam;
            this.oteam = oteam;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            bkgWorker.RunWorkerAsync();
            
        }
    }
}
