namespace kutuphaneyazilim
{
    partial class frmKurumBlgs
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
            this.btnKurumUpd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.txtKurumTel = new System.Windows.Forms.TextBox();
            this.txtKurumAdres = new System.Windows.Forms.TextBox();
            this.txtYonetici = new System.Windows.Forms.TextBox();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKurumUpd
            // 
            this.btnKurumUpd.Location = new System.Drawing.Point(303, 226);
            this.btnKurumUpd.Name = "btnKurumUpd";
            this.btnKurumUpd.Size = new System.Drawing.Size(114, 23);
            this.btnKurumUpd.TabIndex = 0;
            this.btnKurumUpd.Text = "Değiştir";
            this.btnKurumUpd.UseVisualStyleBackColor = true;
            this.btnKurumUpd.Click += new System.EventHandler(this.btnKurumUpd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kurum Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yönetici Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kütüphane Sorumlusu:";
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(149, 44);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(268, 20);
            this.txtKurumAdi.TabIndex = 8;
            // 
            // txtKurumTel
            // 
            this.txtKurumTel.Location = new System.Drawing.Point(149, 75);
            this.txtKurumTel.Name = "txtKurumTel";
            this.txtKurumTel.Size = new System.Drawing.Size(268, 20);
            this.txtKurumTel.TabIndex = 9;
            // 
            // txtKurumAdres
            // 
            this.txtKurumAdres.Location = new System.Drawing.Point(149, 103);
            this.txtKurumAdres.Multiline = true;
            this.txtKurumAdres.Name = "txtKurumAdres";
            this.txtKurumAdres.Size = new System.Drawing.Size(268, 41);
            this.txtKurumAdres.TabIndex = 10;
            // 
            // txtYonetici
            // 
            this.txtYonetici.Location = new System.Drawing.Point(149, 152);
            this.txtYonetici.Name = "txtYonetici";
            this.txtYonetici.Size = new System.Drawing.Size(268, 20);
            this.txtYonetici.TabIndex = 11;
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(149, 186);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(268, 20);
            this.txtYetkili.TabIndex = 12;
            // 
            // frmKurumBlgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 321);
            this.Controls.Add(this.txtYetkili);
            this.Controls.Add(this.txtYonetici);
            this.Controls.Add(this.txtKurumAdres);
            this.Controls.Add(this.txtKurumTel);
            this.Controls.Add(this.txtKurumAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKurumUpd);
            this.Name = "frmKurumBlgs";
            this.ShowIcon = false;
            this.Text = "Kurum Bilgileriniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKurumUpd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.TextBox txtKurumTel;
        private System.Windows.Forms.TextBox txtKurumAdres;
        private System.Windows.Forms.TextBox txtYonetici;
        private System.Windows.Forms.TextBox txtYetkili;
    }
}