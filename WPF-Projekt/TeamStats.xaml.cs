using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for TeamStats.xaml
    /// </summary>
    public partial class TeamStats : Window
    {
        ApiHelper apiHelper = new ApiHelper();
        BackgroundWorker bkgWorker;
        Team team;
        int gs;
        int gt;
        int sumOfMatches;
        int wins;
        int losses;
        public TeamStats()
        {
            SetCulture(apiHelper.LoadSettings().AppLanguage);
            InitializeComponent();
            InitBackGroundWorker();
        }
        private void SetCulture(Language lang)
        {
            if (lang == DataLayer.Model.Language.CRO)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("hr");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
        }
        private void InitBackGroundWorker()
        {
            this.bkgWorker = new BackgroundWorker();
            this.bkgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            this.bkgWorker.DoWork += new DoWorkEventHandler(worker_DoWork);

        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            team = apiHelper.LoadFavoriteTeam();
            gs = apiHelper.GetScoredGoals(team);
            gt = apiHelper.GetTakenGols(team);
            sumOfMatches = apiHelper.GetAllTeamsWhoPlaydWithFavoriteTeam(team).Count;
            wins = apiHelper.GetTeamWins(team);
            losses = apiHelper.GetTeamLosses(team);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblTeamName.Content = team.Country;
            lblFifaCode.Content = team.Code;
            lblSumOfMatches.Content = sumOfMatches;
            lblSumOfWins.Content = wins;
            lblSumOfLosses.Content = losses;
            lblGoalsScored.Content = gs;
            lblSumOfGoalsTaken.Content = gt;
            lblGoalDifference.Content = gs - gt;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bkgWorker.RunWorkerAsync();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
