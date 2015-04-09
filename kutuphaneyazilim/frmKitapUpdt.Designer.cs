namespace kutuphaneyazilim
{
    partial class frmKitapUpdt
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKitapSecim = new System.Windows.Forms.ComboBox();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKitapIDAl = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbKitapDurum = new System.Windows.Forms.ComboBox();
            this.cmbKitapTuru = new System.Windows.Forms.ComboBox();
            this.btnBlgGetir = new System.Windows.Forms.Button();
            this.btnBlgUpdt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap ID";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap bilgilerini güncellemek içn ID numarasını yazmalısınız ya da Kitap İsmini l" +
    "isteden seçmelisiniz";
            // 
            // cmbKitapSecim
            // 
            this.cmbKitapSecim.FormattingEnabled = true;
            this.cmbKitapSecim.Location = new System.Drawing.Point(306, 61);
            this.cmbKitapSecim.Name = "cmbKitapSecim";
            this.cmbKitapSecim.Size = new System.Drawing.Size(121, 21);
            this.cmbKitapSecim.TabIndex = 4;
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(64, 61);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(149, 20);
            this.txtKitapID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kitap Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Açıklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kitap Türü";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "K. Durumu";
            // 
            // txtKitapIDAl
            // 
            this.txtKitapIDAl.HideSelection = false;
            this.txtKitapIDAl.Location = new System.Drawing.Point(64, 157);
            this.txtKitapIDAl.Name = "txtKitapIDAl";
            this.txtKitapIDAl.ReadOnly = true;
            this.txtKitapIDAl.Size = new System.Drawing.Size(149, 20);
            this.txtKitapIDAl.TabIndex = 10;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(64, 196);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(149, 20);
            this.txtKitapAdi.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 154);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 140);
            this.textBox1.TabIndex = 12;
            // 
            // cmbKitapDurum
            // 
            this.cmbKitapDurum.FormattingEnabled = true;
            this.cmbKitapDurum.Location = new System.Drawing.Point(64, 234);
            this.cmbKitapDurum.Name = "cmbKitapDurum";
            this.cmbKitapDurum.Size = new System.Drawing.Size(149, 21);
            this.cmbKitapDurum.TabIndex = 13;
            // 
            // cmbKitapTuru
            // 
            this.cmbKitapTuru.FormattingEnabled = true;
            this.cmbKitapTuru.Location = new System.Drawing.Point(64, 273);
            this.cmbKitapTuru.Name = "cmbKitapTuru";
            this.cmbKitapTuru.Size = new System.Drawing.Size(149, 21);
            this.cmbKitapTuru.TabIndex = 14;
            // 
            // btnBlgGetir
            // 
            this.btnBlgGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBlgGetir.Location = new System.Drawing.Point(210, 87);
            this.btnBlgGetir.Name = "btnBlgGetir";
            this.btnBlgGetir.Size = new System.Drawing.Size(102, 23);
            this.btnBlgGetir.TabIndex = 15;
            this.btnBlgGetir.Text = "Getir";
            this.btnBlgGetir.UseVisualStyleBackColor = false;
            this.btnBlgGetir.Click += new System.EventHandler(this.btnBlgGetir_Click);
            // 
            // btnBlgUpdt
            // 
            this.btnBlgUpdt.BackColor = System.Drawing.Color.Salmon;
            this.btnBlgUpdt.Location = new System.Drawing.Point(210, 316);
            this.btnBlgUpdt.Name = "btnBlgUpdt";
            this.btnBlgUpdt.Size = new System.Drawing.Size(102, 23);
            this.btnBlgUpdt.TabIndex = 16;
            this.btnBlgUpdt.Text = "Güncelle";
            this.btnBlgUpdt.UseVisualStyleBackColor = false;
            this.btnBlgUpdt.Click += new System.EventHandler(this.btnBlgUpdt_Click);
            // 
            // frmKitapUpdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 368);
            this.Controls.Add(this.btnBlgUpdt);
            this.Controls.Add(this.btnBlgGetir);
            this.Controls.Add(this.cmbKitapTuru);
            this.Controls.Add(this.cmbKitapDurum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtKitapIDAl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.cmbKitapSecim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKitapUpdt";
            this.ShowIcon = false;
            this.Text = "Kitap Bilgisi Güncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKitapSecim;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKitapIDAl;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbKitapDurum;
        private System.Windows.Forms.ComboBox cmbKitapTuru;
        private System.Windows.Forms.Button btnBlgGetir;
        private System.Windows.Forms.Button btnBlgUpdt;
    }
}