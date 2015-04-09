namespace kutuphaneyazilim
{
    partial class frmMain
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
            this.kutuphaneMenuStrp = new System.Windows.Forms.MenuStrip();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdminAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuncelleme = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSilmeMn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKitapIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkledb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKitapGüncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTümKitaplar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOduncIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOduncVer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOduncAl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLisansAbt = new System.Windows.Forms.ToolStripMenuItem();
            this.kurumBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKrmUpdt = new System.Windows.Forms.ToolStripMenuItem();
            this.kutuphaneMenuStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // kutuphaneMenuStrp
            // 
            this.kutuphaneMenuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUser,
            this.menuKitapIslemleri,
            this.menuOduncIslemleri,
            this.menuAbout,
            this.kurumBilgisiToolStripMenuItem});
            this.kutuphaneMenuStrp.Location = new System.Drawing.Point(0, 0);
            this.kutuphaneMenuStrp.Name = "kutuphaneMenuStrp";
            this.kutuphaneMenuStrp.Size = new System.Drawing.Size(827, 24);
            this.kutuphaneMenuStrp.TabIndex = 0;
            this.kutuphaneMenuStrp.Text = "menuStrip1";
            // 
            // menuUser
            // 
            this.menuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdminAdd,
            this.menuGuncelleme,
            this.menuSilmeMn});
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(111, 20);
            this.menuUser.Text = "Kullanıcı İşlemleri";
            // 
            // menuAdminAdd
            // 
            this.menuAdminAdd.Name = "menuAdminAdd";
            this.menuAdminAdd.Size = new System.Drawing.Size(168, 22);
            this.menuAdminAdd.Text = "Kullanıcı Oluştur";
            this.menuAdminAdd.Click += new System.EventHandler(this.menuAdminAdd_Click_1);
            // 
            // menuGuncelleme
            // 
            this.menuGuncelleme.Name = "menuGuncelleme";
            this.menuGuncelleme.Size = new System.Drawing.Size(168, 22);
            this.menuGuncelleme.Text = "Kullanıcı Güncelle";
            this.menuGuncelleme.Click += new System.EventHandler(this.menuGuncelleme_Click);
            // 
            // menuSilmeMn
            // 
            this.menuSilmeMn.Name = "menuSilmeMn";
            this.menuSilmeMn.Size = new System.Drawing.Size(168, 22);
            this.menuSilmeMn.Text = "Kullanıcı Silme";
            this.menuSilmeMn.Click += new System.EventHandler(this.menuSilmeMn_Click);
            // 
            // menuKitapIslemleri
            // 
            this.menuKitapIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkledb,
            this.menuKitapGüncelle,
            this.menuTümKitaplar});
            this.menuKitapIslemleri.Name = "menuKitapIslemleri";
            this.menuKitapIslemleri.Size = new System.Drawing.Size(93, 20);
            this.menuKitapIslemleri.Text = "Kitap İşlemleri";
            // 
            // kitapEkledb
            // 
            this.kitapEkledb.Name = "kitapEkledb";
            this.kitapEkledb.Size = new System.Drawing.Size(150, 22);
            this.kitapEkledb.Text = "Kitap Ekle";
            this.kitapEkledb.Click += new System.EventHandler(this.kitapEkledb_Click);
            // 
            // menuKitapGüncelle
            // 
            this.menuKitapGüncelle.Name = "menuKitapGüncelle";
            this.menuKitapGüncelle.Size = new System.Drawing.Size(150, 22);
            this.menuKitapGüncelle.Text = "Kitap Güncelle";
            this.menuKitapGüncelle.Click += new System.EventHandler(this.menuKitapGüncelle_Click);
            // 
            // menuTümKitaplar
            // 
            this.menuTümKitaplar.Name = "menuTümKitaplar";
            this.menuTümKitaplar.Size = new System.Drawing.Size(150, 22);
            this.menuTümKitaplar.Text = "Tüm Kitaplar";
            this.menuTümKitaplar.Click += new System.EventHandler(this.menuTümKitaplar_Click);
            // 
            // menuOduncIslemleri
            // 
            this.menuOduncIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOduncVer,
            this.menuOduncAl});
            this.menuOduncIslemleri.Name = "menuOduncIslemleri";
            this.menuOduncIslemleri.Size = new System.Drawing.Size(102, 20);
            this.menuOduncIslemleri.Text = "Ödünç İşlemleri";
            // 
            // menuOduncVer
            // 
            this.menuOduncVer.Name = "menuOduncVer";
            this.menuOduncVer.Size = new System.Drawing.Size(130, 22);
            this.menuOduncVer.Text = "Ödünç Ver";
            this.menuOduncVer.Click += new System.EventHandler(this.menuOduncVer_Click);
            // 
            // menuOduncAl
            // 
            this.menuOduncAl.Name = "menuOduncAl";
            this.menuOduncAl.Size = new System.Drawing.Size(130, 22);
            this.menuOduncAl.Text = "Geri Al";
            this.menuOduncAl.Click += new System.EventHandler(this.menuOduncAl_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLisansAbt});
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(118, 20);
            this.menuAbout.Text = "Program Hakkinda";
            // 
            // menuLisansAbt
            // 
            this.menuLisansAbt.Name = "menuLisansAbt";
            this.menuLisansAbt.Size = new System.Drawing.Size(161, 22);
            this.menuLisansAbt.Text = "Hakkında-Lisans";
            this.menuLisansAbt.Click += new System.EventHandler(this.menuLisansAbt_Click);
            // 
            // kurumBilgisiToolStripMenuItem
            // 
            this.kurumBilgisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKrmUpdt});
            this.kurumBilgisiToolStripMenuItem.Name = "kurumBilgisiToolStripMenuItem";
            this.kurumBilgisiToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.kurumBilgisiToolStripMenuItem.Text = "Kurum Bilgisi";
            // 
            // menuKrmUpdt
            // 
            this.menuKrmUpdt.Name = "menuKrmUpdt";
            this.menuKrmUpdt.Size = new System.Drawing.Size(152, 22);
            this.menuKrmUpdt.Text = "Düzenle";
            this.menuKrmUpdt.Click += new System.EventHandler(this.menuKrmUpdt_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 429);
            this.Controls.Add(this.kutuphaneMenuStrp);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.kutuphaneMenuStrp;
            this.Name = "frmMain";
            this.kutuphaneMenuStrp.ResumeLayout(false);
            this.kutuphaneMenuStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip kutuphaneMenuStrp;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem menuAdminAdd;
        private System.Windows.Forms.ToolStripMenuItem menuKitapIslemleri;
        private System.Windows.Forms.ToolStripMenuItem kitapEkledb;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuLisansAbt;
        private System.Windows.Forms.ToolStripMenuItem menuGuncelleme;
        private System.Windows.Forms.ToolStripMenuItem menuSilmeMn;
        private System.Windows.Forms.ToolStripMenuItem menuKitapGüncelle;
        private System.Windows.Forms.ToolStripMenuItem menuTümKitaplar;
        private System.Windows.Forms.ToolStripMenuItem menuOduncIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuOduncVer;
        private System.Windows.Forms.ToolStripMenuItem menuOduncAl;
        private System.Windows.Forms.ToolStripMenuItem kurumBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuKrmUpdt;
    }
}

