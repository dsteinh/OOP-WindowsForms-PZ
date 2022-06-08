using DataLayer;
using DataLayer.Dal;
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

namespace UserInterface
{
    public partial class SettingsForm : Form
    {
        
        
        ApiHelper apiHelper = new ApiHelper();
        Settings settings = new Settings();
        public SettingsForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                settings = apiHelper.LoadSettings();
                DisplaySettings();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplaySettings()
        {
            switch (settings.AppLanguage)
            {
                case Language.CRO:
                    rbHRV.Checked = true;
                    break;
                case Language.ENG:
                    rbENG.Checked = true;
                    break;
            }
            switch (settings.TeamsGender)
            {
                case Gender.Male:
                    rbMusko.Checked = true;
                    break;
                case Gender.Female:
                    rbZensko.Checked = true;
                    break;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateSettings();
                apiHelper.SaveSettings(settings, ApiHelper.SettingsPath);
                MainForm owner = (MainForm)this.Owner;
                //ComboBox comboBox = new ComboBox();
                //Control.ControlCollection controls = owner.Controls;
                //comboBox = (ComboBox)controls.Find("cbTeams", true).ToArray().First();
                //comboBox.Items.Clear();
                //apiHelper.GetAllTeams().ToList().ForEach(t => comboBox.Items.Add(t));
                owner.Controls.Clear();
                owner.InitializeAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateSettings()
        {
            if (rbMusko.Checked)
            {
                settings.TeamsGender = Gender.Male;
            }
            if (rbZensko.Checked)
            {
                settings.TeamsGender = Gender.Female;
            }
            if (rbENG.Checked)
            {
                settings.AppLanguage = Language.ENG;
            }
            if (rbHRV.Checked)
            {
                settings.AppLanguage = Language.CRO;
            }
        }
    }
}
