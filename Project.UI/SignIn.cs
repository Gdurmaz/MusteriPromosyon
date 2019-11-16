using System;
using System.Drawing;
using System.Windows.Forms;
using Project.Core.BusinessLayer;

namespace Project.UI
{
    public partial class SignIn : Form
    {
        private StoreServices storeServices;
        public SignIn()
        {
            InitializeComponent();
            storeServices = new StoreServices();
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            storeServices.Select();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMagazaAdi.Text) && !string.IsNullOrEmpty(tbSifre.Text))
            {
                int controlUser = storeServices.Control(I => I.UserName == tbMagazaAdi.Text && I.UserPassword == tbSifre.Text);
                if (controlUser>0)
                {
                    //Bulunan Mağazanın Idsini tutmak için
                    Core.Helper.Method.store_ID = controlUser;
                    AnaForm form = new AnaForm();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adi veya Şifre");
                }
            }
            else
            {
                MessageBox.Show("Alanlar boş geçilemez");
            }
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
        //Panel üstündeki Buttonlar için
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


    }
}
