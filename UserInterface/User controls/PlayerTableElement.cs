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
   
    public partial class PlayerTableElement : UserControl
    {
        public int Goals { get; set; }
        public int YellowCards { get; set; }
        public Player Player { get; set; }
        public PlayerTableElement()
        {
            InitializeComponent();
        }

        private void PlayerTableElement_Load(object sender, EventArgs e)
        {
            lblGolovi.Text = Goals.ToString();
            lblZutiKartoni.Text = YellowCards.ToString();
            lblIme.Text = Player.Name;
        }
    }
}
