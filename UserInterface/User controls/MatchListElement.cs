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
    public partial class MatchListElement : UserControl
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public long Attendance { get; set; }
        public string MatchLocation { get; set; }
        public MatchListElement()
        {
            InitializeComponent();
        }

        private void MatchListElement_Load(object sender, EventArgs e)
        {
            lblTeam1.Text = Team1.Country;
            lblTeam2.Text = Team2.Country;
            lblLokacija.Text = MatchLocation;
            lblDolaznost.Text = Attendance.ToString();

        }
    }
}
