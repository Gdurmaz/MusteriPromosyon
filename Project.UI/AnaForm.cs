using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project.Core.BusinessLayer;
using Project.Core.Entities;
using Project.Core.Helper;
using System.Threading;
using System.Drawing;

namespace Project.UI
{
    public partial class AnaForm : Form
    {
        private CustomerServices customerServices;
        private PromotionalItemsServices promotionalItemsServices;
        private ParticipantsServices participantsServices;
        private StoreServices storeServices;
        public AnaForm()
        {
            InitializeComponent();
            customerServices = new CustomerServices();
            promotionalItemsServices = new PromotionalItemsServices();
            participantsServices = new ParticipantsServices();
            storeServices = new StoreServices();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            //Auto data filling --
            cmbCinsiyet.DataSource = Method.GetGender();
            cmbMeslek.DataSource = Method.GetJobs();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = (this.Controls["gbCustInfo"] as GroupBox);
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;
                }
            }

        }
        /// <summary>
        /// TCKN ait kuralla göre yazıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int controlTCKN = 0;
            if (!string.IsNullOrEmpty(tbTCKN.Text) && !string.IsNullOrEmpty(tbIsim.Text) && !string.IsNullOrEmpty(tbSoyad.Text)
                && !string.IsNullOrEmpty(tbTelefon.Text) && !string.IsNullOrEmpty(tbMail.Text) && cmbCinsiyet.SelectedIndex != -1
                && cmbMeslek.SelectedIndex != -1)
            {
                #region TCKN_Kontrolle_Göre_Metot
                //var checkIdentity = ControlTCKN.ControlIdendity(tbTCKN.Text);
                //if (checkIdentity ==Convert.ToInt32(ControlTCKN.TCKNError.GecerliTCKN))
                //{
                //    controlTCKN = customerServices.Control(I => I.CustomerIdentity == tbTCKN.Text);
                //    if (controlTCKN > 0)
                //    {
                //        MessageBox.Show("Sisteme Kayıtlıdır.");
                //    }
                //    else
                //    {
                //        var controlAdd = customerServices.Insert(new Core.Entities.Customer()
                //        {
                //            CustomerIdentity = tbTCKN.Text,
                //            CustomerName = tbIsim.Text,
                //            CustomerSurName = tbSoyad.Text,
                //            CustomerDateOFBirth = Convert.ToDateTime(dtpDogTar.Value.ToShortDateString()),
                //            CustomerGender = (cmbCinsiyet.SelectedItem as Genders).ID,
                //            CustomerJob = (cmbMeslek.SelectedItem as Job).ID,
                //            CustomerEmail = tbMail.Text,
                //            NotificationAcceptForMail = checkEmail.Checked,
                //            CustomerPhone = tbTelefon.Text,
                //            NotificationAcceptForPhone = checkSMS.Checked,
                //            CreationDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                //            StoreID = Method.store_ID
                //        });
                //        if (controlAdd > 0)
                //        {
                //            MessageBox.Show("Kayıt İşlemi Başarılı olmuştur");
                //            ChoosePromotionalItem();
                //        }
                //        else
                //        {
                //            MessageBox.Show("Hatalı Kayıt");
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show($"Hata Kodu: {checkIdentity} Hata Mesajı:{ControlTCKN.MesageErrorCode(checkIdentity)}");
                //}
                #endregion
                #region TCKN_Kontrolu_Olmadan
                controlTCKN = customerServices.Control(I => I.CustomerIdentity == tbTCKN.Text);
                if (controlTCKN > 0)
                {
                    MessageBox.Show("Sisteme Kayıtlıdır.");
                }
                else
                {
                    var controlAdd = customerServices.Insert(new Core.Entities.Customer()
                    {
                        CustomerIdentity = tbTCKN.Text,
                        CustomerName = tbIsim.Text,
                        CustomerSurName = tbSoyad.Text,
                        CustomerDateOFBirth = Convert.ToDateTime(dtpDogTar.Value.ToShortDateString()),
                        CustomerGender = (cmbCinsiyet.SelectedItem as Genders).ID,
                        CustomerJob = (cmbMeslek.SelectedItem as Job).ID,
                        CustomerEmail = tbMail.Text,
                        NotificationAcceptForMail = checkEmail.Checked,
                        CustomerPhone = tbTelefon.Text,
                        NotificationAcceptForPhone = checkSMS.Checked,
                        CreationDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                        StoreID = Method.store_ID
                    });
                    if (controlAdd > 0)
                    {
                        MessageBox.Show("Kayıt İşlemi Başarılı olmuştur");
                        ChoosePromotionalItem();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kayıt");
                    }
                }
                #endregion
            }
            else
            {
                MessageBox.Show("Eksik hane girdiniz");
            }
        }
        private void ChoosePromotionalItem()
        {
            List<PromotionalItems> Listpromotionals = new List<PromotionalItems>();
            Listpromotionals = promotionalItemsServices.Select(I=>I.CurrentDate>DateTime.Now);
            if (Listpromotionals != null && Listpromotionals.Count > 0)
            {
                for (int i = 0; i < Listpromotionals.Count; i++)
                {
                    Thread.Sleep(100);
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Height = 67;
                    pictureBox.Width = 62;
                    pictureBox.Image = Image.FromFile(@"C:\Users\dell\Source\Repos\MyProject\MusteriPromosyon\Project.Core\Picture\paket.png");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Tag = Listpromotionals[i];
                    pictureBox.Click += PictureBox_Click;
                    flpPromotional.Controls.Add(pictureBox);
                }
            }
            else
            {
                //Log Oluştur
                MessageBox.Show("Kayıtlar Gelmedi");
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureClick = sender as PictureBox;
            PromotionalItems promotional = pictureClick.Tag as PromotionalItems;
            if (promotional != null && promotional.PromotionalID > 0)
            {
                var findPromotionalID = promotionalItemsServices.Find(promotional.PromotionalID);
                var editPromotional = promotionalItemsServices.Update(new PromotionalItems() {
                    IsUsed = findPromotionalID.IsUsed = true
                });
                var controlParticipants = participantsServices.Insert(new Participants()
                {
                    customerID = customerServices.Find(I => I.CustomerIdentity == tbTCKN.Text).CustomerID,
                    PromotionalItemsID = promotional.PromotionalID,
                    StoreID = Method.store_ID,
                    CreationDate = DateTime.Now
                });
                PromosyonForm form = new PromosyonForm(promotional);
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            else
            {
                MessageBox.Show("Sistem hatalı");
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
        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tbTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        private void tbIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);

        }
        #endregion
    }
}
