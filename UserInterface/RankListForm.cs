using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.User_controls;

namespace UserInterface
{
    public partial class RankListForm : Form
    {
        List<Player> allPlayers;
         ApiHelper apiHelper = new ApiHelper();

        private const string HR = "hr";
        private const string EN = "en";
        public RankListForm()
        {
            SetKultura();
            InitializeComponent();
        }

        private  void SetKultura()
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

        private void RankListForm_Load(object sender, EventArgs e)
        {
            allPlayers = (List<Player>)ApiHelper.AllPlayers;
            ShowListOfPlayers();

        }

        private void ShowListOfPlayers()
        {

            allPlayers.ToList().ForEach(p => pnlIgraci.Controls.Add(new PlayerTableElement
            {
                Player = p,
                YellowCards = p.YellowCards,
                Goals = p.Goals,
            }));
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbGolovi.Checked)
            {
                allPlayers.Sort((p2, p1) => p1.Goals.CompareTo(p2.Goals));
            }
            else if (rbZutiKartoni.Checked)
            {
                allPlayers.Sort((p2, p1) => p1.YellowCards.CompareTo(p2.YellowCards));

            }
            pnlIgraci.Controls.Clear();
            ShowListOfPlayers();
            foreach (Control control in pnlIgraci.Controls)
            {
                control.Refresh();
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Add a Panel control.
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            printPreviewDialog1.Document = pd;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }

  
}
