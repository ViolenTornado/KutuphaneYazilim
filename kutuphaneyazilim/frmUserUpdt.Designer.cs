namespace kutuphaneyazilim
{
    partial class frmUserUpdt
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
            this.txtadSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMailUpd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdtUser = new System.Windows.Forms.Button();
            this.dataGridList = new System.Windows.Forms.DataGridView();
            this.cmbDataSecim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAktifPas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatu = new System.Windows.Forms.TextBox();
            this.lblUyari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtadSoyad
            // 
            this.txtadSoyad.Location = new System.Drawing.Point(56, 55);
            this.txtadSoyad.Name = "txtadSoyad";
            this.txtadSoyad.Size = new System.Drawing.Size(125, 20);
            this.txtadSoyad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ad Soyad";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(56, 14);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 20);
            this.txtID.TabIndex = 11;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 17);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 10;
            this.lblid.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aktif";
            // 
            // txtMailUpd
            // 
            this.txtMailUpd.Location = new System.Drawing.Point(285, 55);
            this.txtMailUpd.Name = "txtMailUpd";
            this.txtMailUpd.Size = new System.Drawing.Size(125, 20);
            this.txtMailUpd.TabIndex = 6;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(56, 88);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(125, 20);
            this.txtSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifresi";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(285, 18);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(125, 20);
            this.txtKullaniciAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "K. Adı";
            // 
            // btnUpdtUser
            // 
            this.btnUpdtUser.Location = new System.Drawing.Point(156, 160);
            this.btnUpdtUser.Name = "btnUpdtUser";
            this.btnUpdtUser.Size = new System.Drawing.Size(109, 23);
            this.btnUpdtUser.TabIndex = 9;
            this.btnUpdtUser.Text = "Güncelle";
            this.btnUpdtUser.UseVisualStyleBackColor = true;
            this.btnUpdtUser.Click += new System.EventHandler(this.btnUpdtUser_Click);
            // 
            // dataGridList
            // 
            this.dataGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridList.Location = new System.Drawing.Point(13, 59);
            this.dataGridList.MultiSelect = false;
            this.dataGridList.Name = "dataGridList";
            this.dataGridList.Size = new System.Drawing.Size(630, 236);
            this.dataGridList.TabIndex = 12;
            this.dataGridList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txtBilgileriAktar);
            this.dataGridList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SatirdanBilgileriAlma);
            // 
            // cmbDataSecim
            // 
            this.cmbDataSecim.FormattingEnabled = true;
            this.cmbDataSecim.Items.AddRange(new object[] {
            "Öğrenci",
            "Yetkili"});
            this.cmbDataSecim.Location = new System.Drawing.Point(176, 23);
            this.cmbDataSecim.Name = "cmbDataSecim";
            this.cmbDataSecim.Size = new System.Drawing.Size(152, 21);
            this.cmbDataSecim.TabIndex = 13;
            this.cmbDataSecim.Text = "Seçiminizi Yapınız!";
            this.cmbDataSecim.SelectedIndexChanged += new System.EventHandler(this.cmbDataSecim_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Güncellenecek Grup:";
            // 
            // txtAktifPas
            // 
            this.txtAktifPas.Location = new System.Drawing.Point(285, 91);
            this.txtAktifPas.Name = "txtAktifPas";
            this.txtAktifPas.Size = new System.Drawing.Size(125, 20);
            this.txtAktifPas.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Statü";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtStatu);
            this.panel1.Controls.Add(this.lblUyari);
            this.panel1.Controls.Add(this.txtadSoyad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtKullaniciAd);
            this.panel1.Controls.Add(this.btnUpdtUser);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtAktifPas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMailUpd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Location = new System.Drawing.Point(13, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 202);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(416, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giriş yapmasını istemiyorsanız 0 yapınız";
            // 
            // txtStatu
            // 
            this.txtStatu.Location = new System.Drawing.Point(285, 117);
            this.txtStatu.Name = "txtStatu";
            this.txtStatu.Size = new System.Drawing.Size(125, 20);
            this.txtStatu.TabIndex = 19;
            // 
            // lblUyari
            // 
            this.lblUyari.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUyari.Location = new System.Drawing.Point(282, 143);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(164, 40);
            this.lblUyari.TabIndex = 18;
            this.lblUyari.Text = "Statüyü değiştirmek istiyorsanız Kullanici olarak yapınız!";
            // 
            // frmUserUpdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDataSecim);
            this.Controls.Add(this.dataGridList);
            this.Name = "frmUserUpdt";
            this.ShowIcon = false;
            this.Text = "Kullanıcı Güncelle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMailUpd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdtUser;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtadSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridList;
        private System.Windows.Forms.ComboBox cmbDataSecim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAktifPas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStatu;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label label8;
    }
}