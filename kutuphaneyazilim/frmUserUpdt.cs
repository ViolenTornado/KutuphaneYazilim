using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;


namespace kutuphaneyazilim
{
    public partial class frmUserUpdt : Form
    {
        
         classglb clsfile = new classglb();
         DataTable dt;
      ////   DataRow dr;
         public frmUserUpdt(frmMain Parent)
         {
             InitializeComponent();

             panel1.Visible = false;
                
            
         }

        private void btnUpdtUser_Click(object sender, EventArgs e)
         {
             if (cmbDataSecim.SelectedItem.ToString() == "Öğrenci")
             {
                 clsfile.komut("UPDATE tblKullanici SET adSoyad='"+txtadSoyad.Text+"',numara='"+txtKullaniciAd.Text+"',statu='"+txtMailUpd.Text+"' where kid='"+txtID.Text+"' ");
                 MessageBox.Show(txtadSoyad.Text +" Bilgileri Güncellenmiştir!");
                
                 //foreach (Control item in this.Controls)
                 //{
                 //    if (item is TextBox)
                 //    {
                 //        TextBox txt = item as TextBox;
                 //        txt.Clear();
                 //    }

                 //}

             }
             else if (cmbDataSecim.SelectedItem.ToString() == "Yetkili")
             {
                 clsfile.komut("UPDATE tblYetkiliUye SET ad='" + txtKullaniciAd.Text + "',sifre='" + txtSifre.Text + "',mail='" + txtMailUpd.Text + "',statu='"+txtStatu.Text+"',aktDurum='" + int.Parse(txtAktifPas.Text) + "',uyeadi='" + txtadSoyad.Text + "' where id='" + txtID.Text + "' ");
                 MessageBox.Show(txtadSoyad.Text + " Bilgileri Güncellenmiştir!");
                 //foreach (Control item in this.Controls)
                 //{
                 //    if (item is TextBox)
                 //    {
                 //        TextBox text = item as TextBox;
                 //        text.Clear();
                 //    }

                 //}

             }

             else
             {
                 MessageBox.Show("Bir sorun oluştu. Yöneticinize Bildirin!");
             }
           
            


         }

        
        
         private void cmbDataSecim_SelectedIndexChanged(object sender, EventArgs e)
         {
             
             if (cmbDataSecim.SelectedItem.ToString() == "Öğrenci")
             {
                label1.Text = " Cep Tel";
                label3.Text = "Statü";

                 dt = clsfile.GetDataTable("Select kid,adSoyad,numara,statu from tblKullanici");

                 dataGridList.DataSource = dt;

                 //dataGridList.Columns["loginName"].ColumnName = "Pro. Oluşturan"; //sütun isimlerini değiştiriyor

                 dataGridList.Columns["kid"].HeaderText = "Uye ID";
                 dataGridList.Columns["adSoyad"].HeaderText = "Uye Adı";
                 dataGridList.Columns["numara"].HeaderText = "Telefon Numarası";
                 dataGridList.Columns["statu"].HeaderText = "Statü";
                 
                 panel1.Visible = true;
                 label2.Visible = false;
                 txtSifre.Visible = false;

                 label4.Visible = false;
                 txtAktifPas.Visible = false;

                 label5.Visible = false;
                 txtStatu.Visible = false;
                 lblUyari.Visible = false;
                 label8.Visible = false;



                 

             }
             else if (cmbDataSecim.SelectedItem.ToString() == "Yetkili")
             {
               
                 panel1.Visible = true;
                 label2.Visible = true;
                 txtSifre.Visible = true;
                 label4.Visible = true;
                 txtAktifPas.Visible = true;
                 label5.Visible = true;
                 txtStatu.Visible = true;
                 lblUyari.Visible = true;
                 label8.Visible = true;
               
                
                dt = clsfile.GetDataTable("Select id,ad,sifre,mail,statu,aktDurum,uyeadi from tblYetkiliUye where id>1");
                 dataGridList.DataSource = dt;

                 //dataGridList.Columns["loginName"].ColumnName = "Pro. Oluşturan"; //sütun isimlerini değiştiriyor

                 dataGridList.Columns["id"].HeaderText = "Uye ID";
                 dataGridList.Columns["ad"].HeaderText = "Uye Adı";
                 dataGridList.Columns["sifre"].Visible = true;
                 dataGridList.Columns["mail"].HeaderText = "Mail";
                 dataGridList.Columns["statu"].HeaderText = "Statü";
                 dataGridList.Columns["aktDurum"].HeaderText = "Aktiflik";
                 dataGridList.Columns["uyeadi"].HeaderText = "Üye Adı";
                

             }
             else
             {
                 MessageBox.Show("Beklenmedik başka bir sorunla karşılaşıldı. Yöneticinize Başvurunuz!");
             }
         }

         private void SatirdanBilgileriAlma(object sender, DataGridViewCellMouseEventArgs e)
         {
             // //Form2.TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString

             //try
             //{
             //     //txtID.Text = dataGridList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString();
             //    //txtID.Text = dataGridList.Rows(e.RowIndex).
             //   txtID.Text = this.dataGridList.Rows[1].Cells[0].Value.ToString();
             //}
             //catch (Exception ex)
             //{

             //    MessageBox.Show("Sanırım Bir Hata Oluştu");
             //}
            
         }

         private void txtBilgileriAktar(object sender, DataGridViewCellEventArgs e)
         {
             if (cmbDataSecim.SelectedItem.ToString() == "Öğrenci")
             {
                

                 txtID.Text = this.dataGridList.Rows[e.RowIndex].Cells[0].Value.ToString();
                 txtadSoyad.Text = this.dataGridList.Rows[e.RowIndex].Cells[1].Value.ToString();
                 txtKullaniciAd.Text = this.dataGridList.Rows[e.RowIndex].Cells[2].Value.ToString();
                 txtMailUpd.Text = this.dataGridList.Rows[e.RowIndex].Cells[3].Value.ToString();
               

             }
             else if (cmbDataSecim.SelectedItem.ToString() == "Yetkili")
             {
                 txtID.Text = this.dataGridList.Rows[e.RowIndex].Cells[0].Value.ToString();
                 txtKullaniciAd.Text = this.dataGridList.Rows[e.RowIndex].Cells[1].Value.ToString();
                 txtSifre.Text = this.dataGridList.Rows[e.RowIndex].Cells[2].Value.ToString();
                 txtMailUpd.Text = this.dataGridList.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStatu.Text= this.dataGridList.Rows[e.RowIndex].Cells[4].Value.ToString();
                 txtAktifPas.Text = this.dataGridList.Rows[e.RowIndex].Cells[5].Value.ToString();
                 txtadSoyad.Text = this.dataGridList.Rows[e.RowIndex].Cells[6].Value.ToString();
             }

         }

        
    }
}
