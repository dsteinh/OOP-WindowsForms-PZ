using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.User_controls
{
    public partial class PlayerTile : UserControl
    {
        public string PlayerName { get; set; }
        public string Number { get; set; }
        public string Position { get; set; }
        public bool IsCapetan { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsReadOnly { get; set; } = false;
        public bool IsSelected { get; set; } = false;
        public string ImgPath { get; set; }

        ApiHelper apiHelper = new ApiHelper();
        
        public PlayerTile()
        {
            InitializeComponent();

        }

        private void PlayerTile_Load(object sender, EventArgs e)
        {
            InitPlayer();
        }

        private void InitPlayer()
        {
            if (IsReadOnly)
            {
                imgFavorite.Visible = false;
            }
            lblImeIgraca.Text = PlayerName;
            lblBrojDresa.Text = Number;
            lblPozicija.Text = Position;
            lblKapetan.Text = IsCapetan ? "K" : "";
            imgFavorite.Image = IsFavorite ? Properties.Resources.puna_zvijezda : Properties.Resources.prazna_zvijezda;
            if (File.Exists(ImgPath))
            {
                pictureBox1.Image = Image.FromFile(ImgPath);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.dres1;
            }

        }

        private void imgFavorite_Click(object sender, EventArgs e)
        {


            ToggleFavorite(sender);

            RefreshFavoritePlayers();
        }

        private static void RefreshFavoritePlayers()
        {
            FormCollection openForms = Application.OpenForms;
            //openForms.OfType<FavoritePlayersForm>();
            foreach (Form form in openForms)
            {
                if (form.Name == "FavoritePlayersForm")
                {

                    FavoritePlayersForm favoritePlayersForm = form as FavoritePlayersForm;
                    favoritePlayersForm.Controls.Find("pnlOmiljeniIgraci", true)[0].Controls.Clear();
                    favoritePlayersForm.InitializeAll();

                }
            }
        }

        private void ToggleFavorite(object sender)
        {

            PictureBox control = sender as PictureBox;
            PlayerTile parent = (PlayerTile)control.Parent;
            //PictureBox favImg = (PictureBox)parent.Controls.Find("imgFavorite", false)[0];
            //MainForm mainForm = (MainForm)parent.Owner;

            //control.Controls.Clear();
            if (!parent.IsFavorite)
            {
                AddFavorite(parent);
                parent.IsFavorite = true;
                parent.Refresh();
            }
            else
            {
                RemoveFavorite(parent);
                parent.IsFavorite = false;
                parent.Refresh();
            }

        }

        public void AddFavorite(PlayerTile parent)
        {
            bool ok = apiHelper.AddPlayerToFavorites(new Player
            {
                Name = parent.lblImeIgraca.Text,

                Position = Player.ToPosition(parent.lblPozicija.Text),
                Captain = parent.lblKapetan.Text == "K",
                ShirtNumber = parent.lblBrojDresa.Text
            });
            if (ok)
            {
                parent.imgFavorite.Image = Properties.Resources.puna_zvijezda;

            }
        }

        private void RemoveFavorite(PlayerTile parent)
        {
            //parent.Visible = false;
            parent.imgFavorite.Image = Properties.Resources.prazna_zvijezda;

            apiHelper.RemovePlayerFromFavorites(new Player
            {
                Name = parent.lblImeIgraca.Text,
                IsFavorite = true,
                Position = Player.ToPosition(parent.lblPozicija.Text),
                Captain = parent.lblKapetan.Text == "K",
                ShirtNumber = parent.lblBrojDresa.Text
            });

        }

        private void lblBrojDresa_MouseDown(object sender, MouseEventArgs e)
        {
            StartDnD(this);
        }

        private void StartDnD(PlayerTile playerTile)
        {
            if (!playerTile.IsFavorite)
            {
                playerTile.IsSelected = true;
                playerTile.DoDragDrop(playerTile, DragDropEffects.Move);
                playerTile.IsSelected = false;
                RefreshFavoritePlayers();
            }

        }

        
        private string ChooseImg()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures|*.bmp;*.jpg;*.jpeg;*.png;|All files|*.*";
            ofd.InitialDirectory = Application.StartupPath;

            //ofd.SafeFileName - ime datoteke i ekstenzija
            //ofd.FileName - abs putanja i datoteka
            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
        }

        

        private void btnImg_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            PlayerTile thisPlayer = (PlayerTile)b.Parent;
            string path = ChooseImg();
            thisPlayer.pictureBox1.Image = Image.FromFile(apiHelper.SavePlayerImg(path, thisPlayer.PlayerName));
            RefreshFavoritePlayers();
        }
    }
}
