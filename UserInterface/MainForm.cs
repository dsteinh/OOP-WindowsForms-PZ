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

namespace UserInterface
{
    public partial class MainForm : Form
    {
        ApiHelper apiHelper = new ApiHelper();
        BackgroundWorker bkgWorker;
        
        public MainForm()
        {
            InitializeAll();
        }

        internal void InitializeAll()
        {
            InitializeComponent();
            InitBackGroundWorker();
            bkgWorker.RunWorkerAsync();
        }

        private void InitBackGroundWorker()
        {
            this.bkgWorker = new BackgroundWorker();
            this.bkgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            this.bkgWorker.DoWork += new DoWorkEventHandler(worker_DoWork);
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                apiHelper.GetAllTeams().ToList().ForEach(t => cbTeams.Items.Add(t));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
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
            MessageBox.Show(cb.SelectedItem.GetType().ToString());
            Team team = cb.SelectedItem as Team;
            apiHelper.SaveModel(team, ApiHelper.FavoritePath1);
            
            
        }
    }
}
