using System;
using Project.Core.Entities;
using System.Windows.Forms;
using System.Drawing;

namespace Project.UI
{
    public partial class PromosyonForm : Form
    {
        public PromosyonForm(PromotionalItems items)
        {
            InitializeComponent();
            lblInfo.Text = items.PromotionalName + "\n" + items.Description + "\n Hediyesini Kazandınız...";
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["AnaForm"];
            form.Close();
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Close();
        }
        #region Form_Ayarları
        //1. Panel task bar hareketi için
        bool check = false;
        Point start_point = new Point(0, 0);
        private void pnlTaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            check = false;
        }

        private void pnlTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            check = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pnlTaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (check)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }
        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
