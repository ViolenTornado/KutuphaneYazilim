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
    public partial class frmUserDel : Form
    {
         classglb clsfile = new classglb();
         DataTable dt;
      
         int userid;

         public frmUserDel(frmMain Parent)
        {
            InitializeComponent();
            
         }

         private void btnSİl_Click(object sender, EventArgs e)
         {
             
             if (cmbDataSecim.SelectedIndex>=0)
             {
             if (cmbDataSecim.SelectedItem.ToString() == "Öğrenci")

             {
                clsfile.komut("DELETE from tblKullanici where kid='" + userid + "'");
                dt = clsfile.GetDataTable("Select kid,adSoyad,numara from tblKullanici");
                dataGridDelete.DataSource = dt;
                 MessageBox.Show("Öğrenci Silinmiştir!");
                 //MessageBox.Show("this.dataGridList.Rows[e.RowIndex].Cells[1].Value.ToString()"+"isimli üye listeden silinmiştir!");
                 //this.dataGridList.Rows[e.RowIndex].Cells[0].Value.ToString(); 
             }
             else if (cmbDataSecim.SelectedItem.ToString() == "Yetkili")
             {
                 clsfile.komut("DELETE from tblYetkiliUye where id='" + userid + "'");
                 dt = clsfile.GetDataTable("Select id,ad,statu,uyeadi from tblYetkiliUye where id>1");
                 dataGridDelete.DataSource = dt;
              
                 MessageBox.Show("Yetkili / Kullanıcı Silinmiştir!");
                 //dataGridDelete.Update();
                 //dataGridDelete.Refresh();
             }
             //dataGridDelete.Update();
             //dataGridDelete.Refresh();
         }
             else
             {
                 MessageBox.Show("Grup Seçmemiş ya da Hatalı ya da Eksik Bir işlem yapmış olabilirsiniz!");
             }

             //dataGridDelete.Update();
             //dataGridDelete.Update();
             //dataGridDelete.Refresh();
             //OnRowAddedEvent();
          //   this.customersTableAdapter.Update(this.northwindDataSet.Customers);

           
             //dataGridDelete.Update();
             //dataGridDelete.Refresh();

         }//btn sil 

         //private void OnRowAddedEvent()
         //{
         //    var listener = RowAdded;
         //    if (listener != null)
         //        listener(this, EventArgs.Empty);
         //}

         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cmbDataSecim.SelectedItem.ToString() == "Öğrenci")
             {
                 dt = clsfile.GetDataTable("Select kid,adSoyad,numara from tblKullanici");
                 dataGridDelete.DataSource = dt;
                 dataGridDelete.Columns["kid"].HeaderText = "Uye ID";
                 dataGridDelete.Columns["adSoyad"].HeaderText = "Uye Adı";
                 dataGridDelete.Columns["numara"].HeaderText = "Telefon Numarası";
               
             }
             else if (cmbDataSecim.SelectedItem.ToString() == "Yetkili")
             {
                 dt = clsfile.GetDataTable("Select id,ad,statu,uyeadi from tblYetkiliUye where id>1");
                 dataGridDelete.DataSource = dt;
                 dataGridDelete.Columns["id"].HeaderText = "Uye ID";
                 dataGridDelete.Columns["ad"].HeaderText = "Uye Adı";
                     dataGridDelete.Columns["statu"].HeaderText = "Statü";
                 dataGridDelete.Columns["uyeadi"].HeaderText = "Üye Adı";
             }
             else
             {
                 MessageBox.Show("Beklenmedik başka bir sorunla karşılaşıldı. Yöneticinize Başvurunuz!");
             }
             
         }

         private void txtVeriyiSil(object sender, DataGridViewCellEventArgs e)
         {

             userid= Convert.ToInt32(this.dataGridDelete.Rows[e.RowIndex].Cells[0].Value.ToString());
         }
    }
}
