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
using UserInterface.User_controls;

namespace UserInterface
{
    public partial class FavoritePlayersForm : Form
    {
        ApiHelper apiHelper = new ApiHelper();
        public FavoritePlayersForm()
        {
            InitializeComponent();
            InitializeAll();
        }

        public void InitializeAll()
        {

            ApiHelper.FavoritePlayers.ToList().ForEach(x => pnlOmiljeniIgraci.Controls.Add(new PlayerTile
            {
                PlayerName = x.Name,
                Number = x.ShirtNumber,
                Position = x.Position.ToString(),
                IsCapetan = x.Captain,
                IsFavorite = x.IsFavorite,
                IsReadOnly = true
            }));
            foreach (Control c in pnlOmiljeniIgraci.Controls)
            {
                c.Refresh();
            }
        }



        internal void MyMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form control = sender as Form;
            MainForm owner = control.Owner as MainForm;
            Control[] controls = owner.Controls.Find("button1", true);
            controls[0].Enabled = true;
            controls = owner.Controls.Find("cbTeams", true);
            controls[0].Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            apiHelper.SaveFavoritePlayers(ApiHelper.FavoritePlayers.ToList(), ApiHelper.FavoritePlayersPath);
        }
    }
}
