using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.User_controls;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        ApiHelper apiHelper = new ApiHelper();  
        BackgroundWorker bkgWorker;
        
        Team favoriteTeam;
        public MainForm()
        {
            InitializeAll();
        }

        internal void InitializeAll()
        {
            InitializeComponent();
            InitBackGroundWorker();
            LoadTeam();

            ShowTeams();
            InitPlayers();
            ShowPlayers();

            //bkgWorker.RunWorkerAsync();
        }

        public void ShowPlayers()
        {
            foreach (Player p in ApiHelper.AllPlayers)
            {
                pnlIgraci.Controls.Add(new PlayerTile
                {
                    PlayerName = p.Name,
                    Number = p.ShirtNumber.ToString(),
                    Position = p.Position.ToString(),
                    IsCapetan = p.Captain,
                    IsFavorite = false
                });
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
            try
            {
                ShowTeams();
                InitPlayers();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void InitPlayers()
        {

            try
            {
                ApiHelper.AllPlayers = apiHelper.GetAllPlayers(favoriteTeam).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void ShowTeams()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                apiHelper.GetAllTeams().ToList().ForEach(t => cbTeams.Items.Add(t));
            }
            catch (Exception ex)
            {

               throw ex;
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            try
            {
                Cursor = Cursors.Default;
                ShowPlayers();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(ApiHelper.SettingsPath))
            {
                SettingsForm settingsForm = new SettingsForm();

                settingsForm.ShowDialog(this);
            }



        }



        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(this);
            

        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            Team team = cb.SelectedItem as Team;
            apiHelper.SaveTeam(team, ApiHelper.FavoriteTeamPath);
            this.Controls.Clear();
            ApiHelper.FavoritePlayers.Clear();
            InitializeAll();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           

        }

        private void LoadTeam()
        {
            favoriteTeam = apiHelper.LoadFavoriteTeam();
            cbTeams.Text = favoriteTeam.ToString();
        }

        private void OpenFavoritePlayers_Click(object sender, EventArgs e)
        {
            
            FavoritePlayersForm favoritePlayersForm = new FavoritePlayersForm();
            favoritePlayersForm.Show(this);
            button1.Enabled = false;
            favoritePlayersForm.FormClosing += new FormClosingEventHandler(favoritePlayersForm.MyMainForm_FormClosing);
        }
    }
}
