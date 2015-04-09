namespace kutuphaneyazilim
{
    partial class frmUserDel
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
            this.btnSİl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridDelete = new System.Windows.Forms.DataGridView();
            this.cmbDataSecim = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSİl
            // 
            this.btnSİl.Location = new System.Drawing.Point(176, 279);
            this.btnSİl.Name = "btnSİl";
            this.btnSİl.Size = new System.Drawing.Size(81, 23);
            this.btnSİl.TabIndex = 0;
            this.btnSİl.Text = "SiL";
            this.btnSİl.UseVisualStyleBackColor = true;
            this.btnSİl.Click += new System.EventHandler(this.btnSİl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Not:";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bu alanda işlem yaparken lütfen dikkatli olunuz! Yaptığınız işlemin geri dönüşü y" +
    "oktur ve asla \" Admin \" kullanıcısını silemezsiniz!";
            // 
            // dataGridDelete
            // 
            this.dataGridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDelete.Location = new System.Drawing.Point(12, 92);
            this.dataGridDelete.Name = "dataGridDelete";
            this.dataGridDelete.Size = new System.Drawing.Size(463, 150);
            this.dataGridDelete.TabIndex = 8;
            this.dataGridDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txtVeriyiSil);
            // 
            // cmbDataSecim
            // 
            this.cmbDataSecim.FormattingEnabled = true;
            this.cmbDataSecim.Items.AddRange(new object[] {
            "Öğrenci",
            "Yetkili"});
            this.cmbDataSecim.Location = new System.Drawing.Point(158, 44);
            this.cmbDataSecim.Name = "cmbDataSecim";
            this.cmbDataSecim.Size = new System.Drawing.Size(169, 21);
            this.cmbDataSecim.TabIndex = 9;
            this.cmbDataSecim.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Silinecek Grubun Üyesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Silmek istediğiniz üyenin üzerine tıklayınız ve Sİl butonuna tıkladığınızda üye s" +
    "ilinecektir.";
            // 
            // frmUserDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDataSecim);
            this.Controls.Add(this.dataGridDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSİl);
            this.Name = "frmUserDel";
            this.ShowIcon = false;
            this.Text = "Kullanıcı Sil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSİl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridDelete;
        private System.Windows.Forms.ComboBox cmbDataSecim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}