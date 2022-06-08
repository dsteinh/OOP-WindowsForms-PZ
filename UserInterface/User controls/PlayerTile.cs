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
                    
                    favoritePlayersForm.Load += new EventHandler(favoritePlayersForm.FavoritePlayersForm_Load);
                    foreach (Control c in favoritePlayersForm.Controls)
                    {
                        c.Refresh();
                    }

                }
            }
        }

        private void ToggleFavorite(object sender)
        {

            Control control = sender as Control;
            PlayerTile parent = (PlayerTile)control.Parent;
            //MainForm mainForm = (MainForm)parent.Owner;


            if (parent.IsFavorite)
            {
                RemoveFavorite(parent);
                parent.IsFavorite = false;
                parent.Refresh();
                return;
            }
            bool ok = AddFavorite(parent);

            if (ok)
            {
                parent.IsFavorite = true;
                parent.imgFavorite.Image = Properties.Resources.puna_zvijezda;
                //parent.Visible = false;
                parent.Refresh();

            }
        }

        private bool AddFavorite(PlayerTile parent)
        {
            return apiHelper.AddPlayerToFavorites(new Player
            {
                Name = parent.lblImeIgraca.Text,

                Position = Player.ToPosition(parent.lblPozicija.Text),
                Captain = parent.lblKapetan.Text == "K",
                ShirtNumber = parent.lblBrojDresa.Text
            });
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
