using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //ApiHelper.AllPlayers.ToList().ForEach(p => )
        }

        private void imgFavorite_Click(object sender, EventArgs e)
        {


            ToggleFavorite(sender);



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

        private void AddFavorite(PlayerTile parent)
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

    }
}
