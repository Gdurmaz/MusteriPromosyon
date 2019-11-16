namespace Project.UI
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTaskBar = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.gbPromo = new System.Windows.Forms.GroupBox();
            this.flpPromotional = new System.Windows.Forms.FlowLayoutPanel();
            this.gbCustInfo = new System.Windows.Forms.GroupBox();
            this.dtpDogTar = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbMeslek = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSMS = new System.Windows.Forms.CheckBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbIsim = new System.Windows.Forms.TextBox();
            this.tbTCKN = new System.Windows.Forms.TextBox();
            this.pnlTaskBar.SuspendLayout();
            this.gbPromo.SuspendLayout();
            this.gbCustInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackColor = System.Drawing.Color.SpringGreen;
            this.pnlTaskBar.Controls.Add(this.btnKapat);
            this.pnlTaskBar.Controls.Add(this.btnKucult);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskBar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(781, 44);
            this.pnlTaskBar.TabIndex = 0;
            this.pnlTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseDown);
            this.pnlTaskBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseMove);
            this.pnlTaskBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTaskBar_MouseUp);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(735, 5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(34, 32);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.SkyBlue;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKucult.Location = new System.Drawing.Point(695, 5);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(34, 32);
            this.btnKucult.TabIndex = 6;
            this.btnKucult.Text = "__";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // gbPromo
            // 
            this.gbPromo.Controls.Add(this.flpPromotional);
            this.gbPromo.Location = new System.Drawing.Point(12, 50);
            this.gbPromo.Name = "gbPromo";
            this.gbPromo.Size = new System.Drawing.Size(388, 388);
            this.gbPromo.TabIndex = 1;
            this.gbPromo.TabStop = false;
            // 
            // flpPromotional
            // 
            this.flpPromotional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPromotional.Location = new System.Drawing.Point(3, 16);
            this.flpPromotional.Name = "flpPromotional";
            this.flpPromotional.Size = new System.Drawing.Size(382, 369);
            this.flpPromotional.TabIndex = 0;
            // 
            // gbCustInfo
            // 
            this.gbCustInfo.Controls.Add(this.dtpDogTar);
            this.gbCustInfo.Controls.Add(this.btnCancel);
            this.gbCustInfo.Controls.Add(this.btnSave);
            this.gbCustInfo.Controls.Add(this.cmbCinsiyet);
            this.gbCustInfo.Controls.Add(this.cmbMeslek);
            this.gbCustInfo.Controls.Add(this.label8);
            this.gbCustInfo.Controls.Add(this.label6);
            this.gbCustInfo.Controls.Add(this.label4);
            this.gbCustInfo.Controls.Add(this.label2);
            this.gbCustInfo.Controls.Add(this.label7);
            this.gbCustInfo.Controls.Add(this.label5);
            this.gbCustInfo.Controls.Add(this.label3);
            this.gbCustInfo.Controls.Add(this.label1);
            this.gbCustInfo.Controls.Add(this.checkSMS);
            this.gbCustInfo.Controls.Add(this.checkEmail);
            this.gbCustInfo.Controls.Add(this.tbTelefon);
            this.gbCustInfo.Controls.Add(this.tbMail);
            this.gbCustInfo.Controls.Add(this.tbSoyad);
            this.gbCustInfo.Controls.Add(this.tbIsim);
            this.gbCustInfo.Controls.Add(this.tbTCKN);
            this.gbCustInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbCustInfo.Location = new System.Drawing.Point(406, 50);
            this.gbCustInfo.Name = "gbCustInfo";
            this.gbCustInfo.Size = new System.Drawing.Size(363, 388);
            this.gbCustInfo.TabIndex = 2;
            this.gbCustInfo.TabStop = false;
            // 
            // dtpDogTar
            // 
            this.dtpDogTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogTar.Location = new System.Drawing.Point(171, 100);
            this.dtpDogTar.MaxDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpDogTar.MinDate = new System.DateTime(1923, 10, 29, 0, 0, 0, 0);
            this.dtpDogTar.Name = "dtpDogTar";
            this.dtpDogTar.Size = new System.Drawing.Size(152, 23);
            this.dtpDogTar.TabIndex = 3;
            this.dtpDogTar.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(171, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "İPTAL ET";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(171, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(171, 125);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(152, 23);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // cmbMeslek
            // 
            this.cmbMeslek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeslek.FormattingEnabled = true;
            this.cmbMeslek.ItemHeight = 15;
            this.cmbMeslek.Location = new System.Drawing.Point(171, 152);
            this.cmbMeslek.MaxDropDownItems = 20;
            this.cmbMeslek.Name = "cmbMeslek";
            this.cmbMeslek.Size = new System.Drawing.Size(152, 23);
            this.cmbMeslek.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Telefon(Phone)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Meslek (Job)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum Tarihi (DateOfBirth)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim (Name)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cinsiyet (Gender)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyisim (Surname)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "TCKN (Identity)";
            // 
            // checkSMS
            // 
            this.checkSMS.AutoSize = true;
            this.checkSMS.Location = new System.Drawing.Point(171, 255);
            this.checkSMS.Name = "checkSMS";
            this.checkSMS.Size = new System.Drawing.Size(138, 19);
            this.checkSMS.TabIndex = 9;
            this.checkSMS.Text = "SMS Almak İstiyorum";
            this.checkSMS.UseVisualStyleBackColor = true;
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(171, 206);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(148, 19);
            this.checkEmail.TabIndex = 7;
            this.checkEmail.Text = "E-mail Almak İstiyorum";
            this.checkEmail.UseVisualStyleBackColor = true;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(171, 229);
            this.tbTelefon.MaxLength = 10;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(152, 23);
            this.tbTelefon.TabIndex = 8;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTCKN_KeyPress);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(171, 179);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(152, 23);
            this.tbMail.TabIndex = 6;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(171, 73);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(152, 23);
            this.tbSoyad.TabIndex = 2;
            this.tbSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIsim_KeyPress);
            // 
            // tbIsim
            // 
            this.tbIsim.Location = new System.Drawing.Point(171, 47);
            this.tbIsim.Name = "tbIsim";
            this.tbIsim.Size = new System.Drawing.Size(152, 23);
            this.tbIsim.TabIndex = 1;
            this.tbIsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIsim_KeyPress);
            // 
            // tbTCKN
            // 
            this.tbTCKN.Location = new System.Drawing.Point(171, 21);
            this.tbTCKN.MaxLength = 11;
            this.tbTCKN.Name = "tbTCKN";
            this.tbTCKN.Size = new System.Drawing.Size(152, 23);
            this.tbTCKN.TabIndex = 0;
            this.tbTCKN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTCKN_KeyPress);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.gbCustInfo);
            this.Controls.Add(this.gbPromo);
            this.Controls.Add(this.pnlTaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.pnlTaskBar.ResumeLayout(false);
            this.gbPromo.ResumeLayout(false);
            this.gbCustInfo.ResumeLayout(false);
            this.gbCustInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTaskBar;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.GroupBox gbPromo;
        private System.Windows.Forms.GroupBox gbCustInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkSMS;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbIsim;
        private System.Windows.Forms.TextBox tbTCKN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.ComboBox cmbMeslek;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDogTar;
        private System.Windows.Forms.FlowLayoutPanel flpPromotional;
    }
}