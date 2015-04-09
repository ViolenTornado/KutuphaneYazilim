namespace kutuphaneyazilim
{
    partial class frmKitapEkle
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
            this.txtKitapName = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.btnKitapAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(104, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kütüphanede Mi?";
            // 
            // txtKitapName
            // 
            this.txtKitapName.Location = new System.Drawing.Point(173, 56);
            this.txtKitapName.Name = "txtKitapName";
            this.txtKitapName.Size = new System.Drawing.Size(178, 20);
            this.txtKitapName.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(173, 87);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(178, 84);
            this.txtAciklama.TabIndex = 5;
            this.txtAciklama.Text = "";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(173, 190);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbDurum.TabIndex = 6;
            this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.cmdDurum_SelectedIndexChanged);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(173, 224);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(178, 21);
            this.cmbTur.TabIndex = 7;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.cmbTur_SelectedIndexChanged);
            // 
            // btnKitapAdd
            // 
            this.btnKitapAdd.Location = new System.Drawing.Point(254, 260);
            this.btnKitapAdd.Name = "btnKitapAdd";
            this.btnKitapAdd.Size = new System.Drawing.Size(97, 23);
            this.btnKitapAdd.TabIndex = 8;
            this.btnKitapAdd.Text = "Kitap Ekle";
            this.btnKitapAdd.UseVisualStyleBackColor = true;
            this.btnKitapAdd.Click += new System.EventHandler(this.KitapEkleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // frmKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 340);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKitapAdd);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKitapName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKitapEkle";
            this.ShowIcon = false;
            this.Text = "Kitap Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapName;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button btnKitapAdd;
        private System.Windows.Forms.Label label5;
    }
}