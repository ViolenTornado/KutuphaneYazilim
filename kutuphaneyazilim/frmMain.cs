using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneyazilim
{
    public partial class frmMain : Form
    {
        classglb clsfile = new classglb();
        public int kapat = 0;

        public frmMain()
        {

            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.Text = clsfile.GetDataCell("Select kurumadi from tblkutuphaneBilgileri");
        }
        private void menuAdminAdd_Click_1(object sender, EventArgs e)
        {
            this.menuAdminAdd.Name = "menuYeni";
            this.menuAdminAdd.Size = new System.Drawing.Size(300, 100);
            this.menuAdminAdd.Text = "Yeni Kullanıcı Oluştur";
            this.menuAdminAdd.Click += new System.EventHandler(this.menuAdminAdd_Click);
            frmUserAdd child = new frmUserAdd(this);
            child.MdiParent = this;
            child.Show();
        }

        //private void newUserAdd(object sender, EventArgs e)
        //{
        //    this.menuAdminAdd.Name = "menuYeni";
        //    this.menuAdminAdd.Size = new System.Drawing.Size(150,25);
        //    this.menuAdminAdd.Text = "Yeni Kullanıcı Ekle";
        //    this.menuAdminAdd.Click += new System.EventHandler(this.menuAdminAdd_Click);
        //    //            this.mnItRFPCrt.Name = "mnItRFPCrt";
        //    //this.mnItRFPCrt.Size = new System.Drawing.Size(152, 22);
        //    //this.mnItRFPCrt.Text = "RFP Yarat";
        //    //this.mnItRFPCrt.Click += new System.EventHandler(this.mnItRFPCrt_Click);
        //    //frmRFPCrt child = new frmRFPCrt(this);
        //}

        private void menuAdminAdd_Click(object sender, EventArgs e)
        {
            //frmUserAdd child = new frmUserAdd();
            ////child.Name = "Kullanıcı Ekleme Sayfası";
            ////child.Text = "Kullanıcı Ekleme Sayfası";
            //child.MdiParent = this;
            //child.Show();
        }
        
        private void kitapEkledb_Click(object sender, EventArgs e)
        {
            this.kitapEkledb.Name = "menuKitapEkle";
            this.kitapEkledb.Size = new System.Drawing.Size(300, 100);
            this.kitapEkledb.Text = "Yeni Kitap Ekle";
            frmKitapEkle child = new frmKitapEkle(this);
            child.MdiParent = this;
            child.Show();
            //this.kitapEkledb.Click += new System.EventHandler(this.kitapEkledb_Click);
/*
 * Formun açık olduğu durumlarda Uyarı veren kod
 * /////////////////////////////////////////////////////////////////
            if (Application.OpenForms["frmKitapEkle"]!=null)
            {
                MessageBox.Show("Formunuz Zaten Açık!");
            }
            else if (Application.OpenForms["frmKitapEkle"] == null)
            {
                MessageBox.Show("Formunuz Zaten Açık!");       
            }
 * //////
            *////////////////////////////////////////////////////////////////
            //frmKitapEkle child = new frmKitapEkle(this);
            //child.MdiParent = this;
            //child.Show();
            //kitapEkledb.Visible = false;
            //kitapEkledb.Enabled = false;
            //if (frmKitapEkle.ActiveForm.FormClosed) kitapEkledb.Enabled = true;
        }

               private void menuGuncelleme_Click(object sender, EventArgs e)
        {


            this.menuGuncelleme.Name = "menuGuncelleme";
            this.menuGuncelleme.Size = new System.Drawing.Size(300, 100);
            this.menuGuncelleme.Text = "Kullanıcı Bilgisi Güncelleme";
            frmUserUpdt child = new frmUserUpdt(this);
            child.MdiParent = this;
            child.Show();
        }

        private void menuSilmeMn_Click(object sender, EventArgs e)
        {
            this.menuSilmeMn.Name = "menuSilmeMn";
            this.menuSilmeMn.Size = new System.Drawing.Size(300, 100);
            this.menuSilmeMn.Text = "Kullanıcı Silme İşlemi";
            frmUserDel child = new frmUserDel(this);
            child.MdiParent = this;
            child.Show();
        }

        private void menuKitapGüncelle_Click(object sender, EventArgs e)
        {
            this.menuKitapGüncelle.Name = "menuKitapGüncelle";
            this.menuKitapGüncelle.Size = new System.Drawing.Size(300, 100);
            this.menuKitapGüncelle.Text = "Kitap Bilgisi Güncelleme";
            frmKitapUpdt child = new frmKitapUpdt(this);
            child.MdiParent = this;
            child.Show();

        }

        private void menuTümKitaplar_Click(object sender, EventArgs e)
        {
            this.menuTümKitaplar.Name = "menuTümKitaplar";
            this.menuTümKitaplar.Size = new System.Drawing.Size(300, 100);
            this.menuTümKitaplar.Text = "Tüm Kitap Listesi";
            frmKitapList child = new frmKitapList(this);
            child.MdiParent = this;
            child.Show();
        }

        private void menuOduncVer_Click(object sender, EventArgs e)
        {
            this.menuOduncVer.Name = "menuOduncVer";
            this.menuOduncVer.Size = new System.Drawing.Size(300, 100);
            this.menuOduncVer.Text = "Ödünç Ver";
            frmOduncVer child = new frmOduncVer(this);
            child.MdiParent = this;
            child.Show();

        }

        private void menuOduncAl_Click(object sender, EventArgs e)
        {
            this.menuOduncAl.Name = "menuOduncAl";
            this.menuOduncAl.Size = new System.Drawing.Size(300, 100);
            this.menuOduncAl.Text = "Ödünç Geri Al";
            frmOduncGeriAl child = new frmOduncGeriAl(this);
            child.MdiParent = this;
            child.Show();
        }

        private void menuLisansAbt_Click(object sender, EventArgs e)
        {
            this.menuLisansAbt.Name = "menuLisansAbt";
            this.menuLisansAbt.Size = new System.Drawing.Size(300, 100);
            this.menuLisansAbt.Text = "Hakkında-Lisans";

            if (Application.OpenForms["frmLisans"] != null)
            {
                MessageBox.Show("Formunuz Zaten Açık!");
               

            }
            else if (Application.OpenForms["frmLisans"] == null)
            {
                frmLisans child = new frmLisans();
                child.MdiParent = this;
                child.Show();

            }
            
            
            
           
        }

        

        private void menuKrmUpdt_Click(object sender, EventArgs e)
        {
            this.menuLisansAbt.Name = "menuLisansAbt";
            this.menuLisansAbt.Size = new System.Drawing.Size(300, 100);
            this.menuLisansAbt.Text = "Hakkında-Lisans";

            frmKurumBlgs child = new frmKurumBlgs(this);
            child.MdiParent = this;
            child.Show();
        }

        

        


        //        if (Application.OpenForms["frmKitapEkle"] != null)
        //{
        //    MessageBox.Show("Form Zaten Açık");
        //}

        //        else
        //        {
        //       kitapEkledb_Click();
        //        }





    }
    
}
