using DataLayer;
using DataLayer.Model;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string MessageBoxTitle = "Are you sure?";
        private const string MessageBoxMessage = "Closing Confirmation";
        ApiHelper apiHelper = new ApiHelper();
        Settings settings = new Settings();
        Team favoriteTeam = new Team();
        BackgroundWorker bkgWorker;
        List<Team> _teams;
        public MainWindow()
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
            settings = apiHelper.LoadSettings();
            _teams = apiHelper.GetAllTeams().ToList();
            favoriteTeam = apiHelper.LoadFavoriteTeam();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cbFavoriteTeam.Items.Clear();
            ShowSettings();
            SetResolution();
            ShowTeams();
            ShowFavoriteTeam();
            this.Cursor = Cursors.Arrow;
        }

        private void ShowTeams()
        {
            _teams.ForEach(t => cbFavoriteTeam.Items.Add(t));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.Wait;
                bkgWorker.RunWorkerAsync(); 

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SetResolution()
        {
            switch (settings.Resolution)
            {
                case Resolution.Fullscreen:
                    this.Visibility = Visibility.Collapsed;
                    MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
                    MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
                    ResizeMode = ResizeMode.NoResize;
                    this.WindowState = WindowState.Maximized;
                    this.WindowStyle = WindowStyle.None;
                    this.ShowInTaskbar = false;
                    this.Visibility = Visibility.Visible;
                    break;
                case Resolution.FHD:
                    this.WindowStyle = WindowStyle.ThreeDBorderWindow;
                    this.WindowState = WindowState.Normal;
                    this.Width = 1280;
                    this.Height = 720;
                    this.ShowInTaskbar = true;
                    ResizeMode = ResizeMode.CanResize;

                    break;
                case Resolution.VGA:
                    this.WindowStyle = WindowStyle.ThreeDBorderWindow;
                    this.WindowState = WindowState.Normal;
                    this.Width = 640;
                    this.Height = 480;
                    this.ShowInTaskbar = true;
                    ResizeMode = ResizeMode.CanResize;

                    break;

            }
        }
        private void ShowFavoriteTeam()
        {
            if (favoriteTeam == null)
            {
                return;
            }
            cbFavoriteTeam.Text = favoriteTeam.ToString();
        }

        private void ShowSettings()
        {

            switch (settings.AppLanguage)
            {
                case DataLayer.Model.Language.CRO:
                    rbHRV.IsChecked = true;
                    break;
                case DataLayer.Model.Language.ENG:
                    rbENG.IsChecked = true;
                    break;
            }
            switch (settings.TeamsGender)
            {
                case Gender.Male:
                    rbMale.IsChecked = true;
                    break;
                case Gender.Female:
                    rbFemale.IsChecked = true;
                    break;

            }
            switch (settings.Resolution)
            {
                case Resolution.Fullscreen:
                    rbFscr.IsChecked = true;
                    break;
                case Resolution.FHD:
                    rbHD.IsChecked = true;
                    break;
                case Resolution.VGA:
                    rbVGA.IsChecked = true;
                    break;
            }
        }

   
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Settings changing", System.Windows.MessageBoxButton.YesNo);

            if (messageBoxResult == MessageBoxResult.No)
            {
                return;
            }
            try
            {
                UpdateSettings();
                SetCulture(settings.AppLanguage);
                apiHelper.SaveSettings(settings, ApiHelper.SettingsPath);
                SetResolution();
                bkgWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateSettings()
        {
            if (rbMale.IsChecked == true)
            {
                settings.TeamsGender = Gender.Male;
            }
            if (rbFemale.IsChecked == true)
            {
                settings.TeamsGender = Gender.Female;
            }
            if (rbENG.IsChecked == true)
            {
                settings.AppLanguage = DataLayer.Model.Language.ENG;
            }
            if (rbHRV.IsChecked == true)
            {
                settings.AppLanguage = DataLayer.Model.Language.CRO;
            }
            if (rbFscr.IsChecked == true)
            {
                settings.Resolution = Resolution.Fullscreen;
            }
            if (rbHD.IsChecked == true)
            {
                settings.Resolution = Resolution.FHD;
            }
            if (rbVGA.IsChecked == true)
            {
                settings.Resolution = Resolution.VGA;
            }
        }





        private void LoadOtherTeam()
        {
            if (favoriteTeam != null)
            {
                IList<Team> teams = apiHelper.GetAllTeamsWhoPlaydWithFavoriteTeam(favoriteTeam);
                teams.ToList().ForEach(t => cbOtherTeam.Items.Add(t));
            }

        }

        private void cbFavoriteTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            favoriteTeam = cbFavoriteTeam.SelectedItem as Team;
            if (favoriteTeam != null)
            apiHelper.SaveTeam(favoriteTeam, ApiHelper.FavoriteTeamPath);
            cbOtherTeam.Items.Clear();
            LoadOtherTeam();



        }

        private void btnShowRes_Click(object sender, RoutedEventArgs e)
        {
            Team fteam = cbFavoriteTeam.SelectedItem as Team;
            Team oteam = cbOtherTeam.SelectedItem as Team;

            try
            {
                Match match = apiHelper.GetMatchByTeams(fteam, oteam);
                if (match.HomeTeam.CodeForCheck == fteam.Code)
                {
                    lblFavoriteRes.Content = match.HomeTeam.Goals.ToString();
                    lblOtherRes.Content = match.AwayTeam.Goals.ToString();
                }
                else
                {
                    lblOtherRes.Content = match.HomeTeam.Goals.ToString();
                    lblFavoriteRes.Content = match.AwayTeam.Goals.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnTeamStats_Click(object sender, RoutedEventArgs e)
        {
            TeamStats teamStatsWindow = new TeamStats();
            teamStatsWindow.ShowDialog();
        }

        private void btnPlayers_Click(object sender, RoutedEventArgs e)
        {
            if (cbOtherTeam.SelectedItem == null)
            {
                return;
            }
            Team fteam = cbFavoriteTeam.SelectedItem as Team;
            Team oteam = cbOtherTeam.SelectedItem as Team;

            PlayerPositions teamStatsWindow = new PlayerPositions(fteam, oteam);
            teamStatsWindow.ShowDialog();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(MessageBoxTitle, MessageBoxMessage, System.Windows.MessageBoxButton.YesNo);
         
            if (messageBoxResult == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
