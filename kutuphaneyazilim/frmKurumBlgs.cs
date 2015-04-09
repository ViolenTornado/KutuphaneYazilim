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
    public partial class frmKurumBlgs : Form
    {
        classglb clsfile = new classglb();
    
      
        public frmKurumBlgs(frmMain Parent)
        {
            InitializeComponent();
            DataTable dt = clsfile.GetDataTable("Select * from tblkutuphaneBilgileri");
            int i=0;
            while(i<dt.Rows.Count)
            {
                DataRow dr = dt.Rows[i];
                txtKurumAdi.Text=dr["kurumAdi"].ToString();
                clsfile.kurumadi = dr["kurumAdi"].ToString();
                
                txtKurumTel.Text = dr["telefon"].ToString();
                txtKurumAdres.Text = dr["adres"].ToString();
                txtYonetici.Text = dr["yoneticiad"].ToString();
                txtYetkili.Text = dr["sorumlu"].ToString(); ;
                i++;
            }
            
        }

        private void btnKurumUpd_Click(object sender, EventArgs e)
        {
            clsfile.komut("UPDATE tblkutuphaneBilgileri SET kurumadi='"+txtKurumAdi.Text+"',telefon='"+txtKurumTel.Text+"',adres= '"+txtKurumAdres.Text+"',yoneticiad='"+ txtYonetici.Text+"' ,sorumlu='"+txtYetkili.Text+"'  where id=1");
            MessageBox.Show("Bilgileriniz Güncellenmiştir! Form Kapatılacaktır.");
            Close();
        }
    }
}
