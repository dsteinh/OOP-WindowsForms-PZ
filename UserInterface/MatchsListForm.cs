using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.User_controls;

namespace UserInterface
{
    public partial class MatchsListForm : Form
    {
        List<Match> matches;
        public MatchsListForm()
        {
            InitializeComponent();
            
        }

        private void MatchsListForm_Load(object sender, EventArgs e)
        {
            ApiHelper apiHelper = new ApiHelper();
            matches = (List<Match>)apiHelper.GetAllMatches();
            ShowListOfMatches();

        }

        private void ShowListOfMatches()
        {
            matches.ToList().ForEach(match => pnlUtakmice.Controls.Add(new MatchListElement
            {
                MatchLocation = match.Location,
                Attendance = match.Attendance,
                Team1 = match.HomeTeam,
                Team2 = match.AwayTeam
            }));
        }

        private void rbLokacija_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLokacija.Checked)
            {
                matches.Sort((m1, m2) => m1.Location.CompareTo(m2.Location));
            }
            else if (rbDolaznost.Checked)
            {
                matches.Sort((m2, m1) => m1.Attendance.CompareTo(m2.Attendance));

            }
            pnlUtakmice.Controls.Clear();
            ShowListOfMatches();
            foreach (Control control in pnlUtakmice.Controls)
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
