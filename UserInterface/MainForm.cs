using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private const string HR = "hr";
        private const string EN = "en";
        private const string ImgDir = @"..\..\..\DataLayer\Imgs";
        ApiHelper apiHelper = new ApiHelper();
        BackgroundWorker bkgWorker;

        Team favoriteTeam;
        public MainForm()
        {
            SetKultura();
            InitializeAll();

        }

        internal void InitializeAll()
        {
            InitializeComponent();
            InitBackGroundWorker();
            LoadTeam();

            //ShowTeams();
            //InitPlayers();
            //ShowPlayers();

            bkgWorker.RunWorkerAsync();
        }

        public void ShowPlayers()
        {
            IList<Player> players = apiHelper.LoadFavoritePlayers();
            ApiHelper.FavoritePlayers = players;
            LoadIfFavorites();

            foreach (Player p in ApiHelper.AllPlayers)
            {
                pnlIgraci.Controls.Add(new PlayerTile
                {
                    PlayerName = p.Name,
                    Number = p.ShirtNumber.ToString(),
                    Position = p.Position.ToString(),
                    IsCapetan = p.Captain,
                    IsFavorite = p.IsFavorite,
                    ImgPath = apiHelper.GetImgPath(p.Name)
                });

            }


            foreach (PlayerTile item in pnlIgraci.Controls)
            {
                item.MouseHover += Item_MouseHover;
            }


        }

        private void Item_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Dodir");
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
                apiHelper.SetYellowCards();
                apiHelper.SetGoals();
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

                MessageBox.Show(ex.Message); ;
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

        internal void SetKultura()
        {
            if (apiHelper.LoadSettings().AppLanguage == Language.CRO)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(HR);
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(EN);
            }
        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            Team team = cb.SelectedItem as Team;
            apiHelper.SaveTeam(team, ApiHelper.FavoriteTeamPath);
            this.Controls.Clear();

            InitializeAll();
            ApiHelper.FavoritePlayers.Clear();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadIfFavorites()
        {
            IList<Player> test = ApiHelper.FavoritePlayers;
            foreach (Player p in ApiHelper.AllPlayers)
            {
                foreach (Player pl in ApiHelper.FavoritePlayers)
                {
                    if (p.Name == pl.Name)
                    {
                        p.IsFavorite = true;
                    }
                }

            }
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
            cbTeams.Enabled = false;
            favoritePlayersForm.FormClosing += new FormClosingEventHandler(favoritePlayersForm.MyMainForm_FormClosing);
            FlowLayoutPanel pnlOmiljeni = (FlowLayoutPanel)favoritePlayersForm.Controls.Find("pnlOmiljeniIgraci", true)[0];


        }



        private void ShowPlayerStatsList_Click(object sender, EventArgs e)
        {
            RankListForm rankListForm = new RankListForm();
            rankListForm.ShowDialog(this);

        }

        private void ShowMatchStatsList_Click(object sender, EventArgs e)
        {
            MatchsListForm matchsListForm = new MatchsListForm();
            matchsListForm.ShowDialog(this);
        }

      

        private void pnlIgraci_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnlZvijezde_DragDrop(object sender, DragEventArgs e)
        {

            foreach (PlayerTile pt in pnlIgraci.Controls)
            {
                if (pt.IsSelected)
                {
                    pt.AddFavorite(pt);
                    pt.IsFavorite = true;
                }
            }
        }

        private void pnlZvijezde_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }
    }
}
