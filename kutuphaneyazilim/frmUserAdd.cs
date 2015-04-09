using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneyazilim
{
    public partial class frmUserAdd : Form
        
    {
        classglb clsfile = new classglb();
     
       
        public frmUserAdd(frmMain Parent)
        {

            InitializeComponent();

            //DataRow drytk = clsfile.GetDataRow("Select ad from tblYetkiliUye");
            //label8.Text = drytk["ad"].ToString();
            //DataRow ogrenci = clsfile.GetDataRow("Select numara from tblKullanici");
            pnlKullaniciEkle.Visible = false;
            //DataTable dt = clsfile.GetDataTable("Select * from tblYetkiliUye");
            //for (int i  = 0; i  <dt.Rows.Count; i ++)
            //{
            //    DataRow dr=dt.Rows[i];
            //    cmbStatu.Items.Add(dr["statu"].ToString());	 
            //}
        }

        private void rbAdminEkle_CheckedChanged(object sender, EventArgs e)
        {
            pnlKullaniciEkle.Visible = true;
            lblStatu.Visible = true;
            cmbStatu.Visible = true;
            cmbStatu.Items.Clear();
            cmbStatu.Items.Add("Admin");
            cmbStatu.Items.Add("Kullanici");
            pnlKullaniciEkle.Visible = true;
            pnlKullaniciEkle.Location = new Point(30,80);
            pnlOgrenciEkle.Visible = false;
     
        }

        private void rbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            pnlKullaniciEkle.Visible = false;
            pnlOgrenciEkle.Visible = true;
            pnlOgrenciEkle.Location = new Point(30, 80);
            cmbOgr.Items.Add("Öğrenci");
           
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            
          
            //if (txtKullaniciAd.Text != clsfile.GetDataRow("Select ad from tblYetkiliUye").ToString()  ||  txtCep.Text != clsfile.GetDataRow("Select numara from tblKullanici").ToString() )
            //{
            if(rbAdminEkle.Checked==true)
            {
                clsfile.komut("INSERT INTO tblYetkiliUye (ad,sifre,mail,statu,aktDurum,uyeadi) VALUES ('" + txtKullaniciAd.Text + "','" + txtSifre.Text + "','" + txtMail.Text + "','" + cmbStatu.SelectedItem.ToString() + "',1,'"+txtAdSoyad.Text+"')");
                MessageBox.Show("Kullanıcı Eklenmiştir.");
                Close();
               
            }
            else if(rbOgrenci.Checked==true)
            {

                clsfile.komut("INSERT INTO tblKullanici (adSoyad,numara,statu) VALUES ('" + txtOgrAd.Text + "','" + txtCep.Text + "','" + cmbOgr.SelectedItem.ToString() + "')");
                MessageBox.Show("Öğrenciniz Eklenmiştir Eklenmiştir.");
                Close();
            }
                else{  MessageBox.Show("Seçeneklerden birisini seçmek zorundasınız!");}
            //}
 
           //else {MessageBox.Show("Bu kullanıcılar Zaten Kayıtlı!");
           // }     
            
        }

        private void cmbStatu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statuSecim = cmbStatu.SelectedItem.ToString();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece numerik kullanma izni
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;    
        }

        private void ceptelefonu(object sender, KeyPressEventArgs e)
        {
            //sadece numerik kullanma izni
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8)
                e.Handled = true;   
        }
    }
}
