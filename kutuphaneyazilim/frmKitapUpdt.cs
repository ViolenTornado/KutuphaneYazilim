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
    public partial class frmKitapUpdt : Form
    {
        classglb clsfile = new classglb();
   
        public frmKitapUpdt(frmMain Parent)
        {
            InitializeComponent();
           DataTable dt= clsfile.GetDataTable("Select kid,kitapAdi from tblKitapBilgisi");
           
            for (int i = 0; i <dt.Rows.Count ; i++)
            {
                DataRow dr = dt.Rows[i];
                cmbKitapSecim.Items.Add(dr["kitapAdi"].ToString());
                
            }
        }

        private void btnBlgGetir_Click(object sender, EventArgs e)
        {
           if(cmbKitapSecim.SelectedIndex<0) 
           {
               if(txtKitapID.Text!="")
               {
                   MessageBox.Show("Kitap Bilgileri Getirildi");//kitap bilgilerini getirecek ve txt sıfırlanacak
                   txtKitapID.Text = "";
               }
               else if (txtKitapID.Text=="")
               {
                   MessageBox.Show("En Az Bir alana bilgi girmelisiniz!");
               }

           }

           else if(cmbKitapSecim.SelectedIndex>=0)
           {
               //eğer cmb den seçim yapılmışsa txt sıfırlanacak ve combo değeri alınarak oda sıfırlanacak
               txtKitapID.Text = "";

               MessageBox.Show("Kitap Bilgilerinizi Aldık ....");
               cmbKitapSecim.SelectedIndex = -1;
           }
        }

        private void btnBlgUpdt_Click(object sender, EventArgs e)
        {

        }
    }
}
