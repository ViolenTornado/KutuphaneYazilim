namespace kutuphaneyazilim
{
    partial class frmUserAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatu = new System.Windows.Forms.Label();
            this.pnlKullaniciEkle = new System.Windows.Forms.Panel();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.rbAdminEkle = new System.Windows.Forms.RadioButton();
            this.rbOgrenci = new System.Windows.Forms.RadioButton();
            this.pnlOgrenciEkle = new System.Windows.Forms.Panel();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.cmbOgr = new System.Windows.Forms.ComboBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlKullaniciEkle.SuspendLayout();
            this.pnlOgrenciEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatu
            // 
            this.lblStatu.AutoSize = true;
            this.lblStatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatu.Location = new System.Drawing.Point(43, 114);
            this.lblStatu.Name = "lblStatu";
            this.lblStatu.Size = new System.Drawing.Size(41, 13);
            this.lblStatu.TabIndex = 3;
            this.lblStatu.Text = "Statü:";
            this.lblStatu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKullaniciEkle
            // 
            this.pnlKullaniciEkle.Controls.Add(this.txtAdSoyad);
            this.pnlKullaniciEkle.Controls.Add(this.label6);
            this.pnlKullaniciEkle.Controls.Add(this.txtMail);
            this.pnlKullaniciEkle.Controls.Add(this.txtSifre);
            this.pnlKullaniciEkle.Controls.Add(this.cmbStatu);
            this.pnlKullaniciEkle.Controls.Add(this.txtKullaniciAd);
            this.pnlKullaniciEkle.Controls.Add(this.lblStatu);
            this.pnlKullaniciEkle.Controls.Add(this.label1);
            this.pnlKullaniciEkle.Controls.Add(this.label3);
            this.pnlKullaniciEkle.Controls.Add(this.label2);
            this.pnlKullaniciEkle.Location = new System.Drawing.Point(30, 80);
            this.pnlKullaniciEkle.Name = "pnlKullaniciEkle";
            this.pnlKullaniciEkle.Size = new System.Drawing.Size(300, 148);
            this.pnlKullaniciEkle.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(106, 31);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtAdSoyad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ad Soyad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(106, 85);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(125, 20);
            this.txtMail.TabIndex = 10;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(106, 59);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(125, 20);
            this.txtSifre.TabIndex = 9;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // cmbStatu
            // 
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(106, 111);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(125, 21);
            this.cmbStatu.TabIndex = 7;
            this.cmbStatu.SelectedIndexChanged += new System.EventHandler(this.cmbStatu_SelectedIndexChanged);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(106, 5);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(125, 20);
            this.txtKullaniciAd.TabIndex = 4;
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(140, 234);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(121, 23);
            this.btnUyeEkle.TabIndex = 8;
            this.btnUyeEkle.Text = "Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // rbAdminEkle
            // 
            this.rbAdminEkle.AutoSize = true;
            this.rbAdminEkle.Location = new System.Drawing.Point(61, 42);
            this.rbAdminEkle.Name = "rbAdminEkle";
            this.rbAdminEkle.Size = new System.Drawing.Size(126, 17);
            this.rbAdminEkle.TabIndex = 5;
            this.rbAdminEkle.TabStop = true;
            this.rbAdminEkle.Text = "Admin - Kullanıcı Ekle";
            this.rbAdminEkle.UseVisualStyleBackColor = true;
            this.rbAdminEkle.CheckedChanged += new System.EventHandler(this.rbAdminEkle_CheckedChanged);
            // 
            // rbOgrenci
            // 
            this.rbOgrenci.AutoSize = true;
            this.rbOgrenci.Location = new System.Drawing.Point(215, 42);
            this.rbOgrenci.Name = "rbOgrenci";
            this.rbOgrenci.Size = new System.Drawing.Size(86, 17);
            this.rbOgrenci.TabIndex = 6;
            this.rbOgrenci.TabStop = true;
            this.rbOgrenci.Text = "Öğrenci Ekle";
            this.rbOgrenci.UseVisualStyleBackColor = true;
            this.rbOgrenci.CheckedChanged += new System.EventHandler(this.rbOgrenci_CheckedChanged);
            // 
            // pnlOgrenciEkle
            // 
            this.pnlOgrenciEkle.Controls.Add(this.txtCep);
            this.pnlOgrenciEkle.Controls.Add(this.cmbOgr);
            this.pnlOgrenciEkle.Controls.Add(this.txtOgrAd);
            this.pnlOgrenciEkle.Controls.Add(this.label4);
            this.pnlOgrenciEkle.Controls.Add(this.label5);
            this.pnlOgrenciEkle.Controls.Add(this.label7);
            this.pnlOgrenciEkle.Location = new System.Drawing.Point(28, 263);
            this.pnlOgrenciEkle.Name = "pnlOgrenciEkle";
            this.pnlOgrenciEkle.Size = new System.Drawing.Size(300, 120);
            this.pnlOgrenciEkle.TabIndex = 11;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(106, 37);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(125, 20);
            this.txtCep.TabIndex = 9;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceptelefonu);
            // 
            // cmbOgr
            // 
            this.cmbOgr.FormattingEnabled = true;
            this.cmbOgr.Location = new System.Drawing.Point(106, 69);
            this.cmbOgr.Name = "cmbOgr";
            this.cmbOgr.Size = new System.Drawing.Size(125, 21);
            this.cmbOgr.TabIndex = 7;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(106, 5);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(125, 20);
            this.txtOgrAd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Statü:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Öğrenci Adı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cep Telefonu:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // frmUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlOgrenciEkle);
            this.Controls.Add(this.rbOgrenci);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.rbAdminEkle);
            this.Controls.Add(this.pnlKullaniciEkle);
            this.Name = "frmUserAdd";
            this.ShowIcon = false;
            this.Text = "Kullanıcı - Öğrenci Ekle";
            this.pnlKullaniciEkle.ResumeLayout(false);
            this.pnlKullaniciEkle.PerformLayout();
            this.pnlOgrenciEkle.ResumeLayout(false);
            this.pnlOgrenciEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatu;
        private System.Windows.Forms.Panel pnlKullaniciEkle;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.RadioButton rbAdminEkle;
        private System.Windows.Forms.RadioButton rbOgrenci;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Panel pnlOgrenciEkle;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOgr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;

    }
}