using DataLayer;
using DataLayer.Dal;
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

namespace UserInterface
{
    public partial class Form1 : Form
    {
        ApiHelper ah = new ApiHelper();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }

        private void LoadTeams()
        {

            ah.GetAllTeams().ToList().ForEach(team => cbTeams.Items.Add(team));
        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIgraci.Items.Clear();
            ComboBox comboBox = sender as ComboBox;

            Team team = comboBox.SelectedItem as Team;

            ah.GetAllPlayers(team).ToList().ForEach(player => lbIgraci.Items.Add(player));
        }
    }
}
