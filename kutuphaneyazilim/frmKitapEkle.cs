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
    
    
    public partial class frmKitapEkle : Form
    {
        classglb clsfile = new classglb();
        DataTable drmdt, turdt;
        public frmKitapEkle(frmMain Parent)
        {
            InitializeComponent();
                        cmbAlanlariDoldur();// combo alanlarını doldur
            
        }

        private void cmbAlanlariDoldur()// combo alanlarını doldur
        {
             drmdt = clsfile.GetDataTable("Select durumid,durumAdi From tblDurumBlgs");
             turdt = clsfile.GetDataTable("Select tid,turadi from tblTurBlgs");
                      for (int i = 0; i < drmdt.Rows.Count; i++)
            {
                DataRow dr = drmdt.Rows[i];
                cmbDurum.Items.Add(dr["durumAdi"].ToString());
                
            }

            for (int i = 0; i < turdt.Rows.Count; i++)
            {
                DataRow dr = turdt.Rows[i];
                cmbTur.Items.Add(dr["turadi"].ToString());
            }
            cmbDurum.SelectedIndex = 1;
        }

        private void cmdDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
           // //dtCstmr.Rows[cmbCstmr.SelectedIndex]["lgLogRef"]
           //label5.Text= drmdt.Rows[cmbDurum.SelectedIndex]["durumid"].ToString();
           // // cmb den seçildiğinde veri tabanından İD alacak olan kod

            
        }

        private void KitapEkleClick(object sender, EventArgs e)
        {


            clsfile.komut("INSERT INTO tblKitapBilgisi(kitapAdi,aciklama,durumid,turid) VALUES('" + txtKitapName.Text + "','" + txtAciklama.Text + "','" + int.Parse(drmdt.Rows[cmbDurum.SelectedIndex]["durumid"].ToString()) + "','" + Convert.ToInt32(turdt.Rows[cmbTur.SelectedIndex]["tid"].ToString()) + "') ");
            MessageBox.Show("Kitabınız Başarıyla Eklenmiştir. Veri Alanları Sıfırlandı.");
            txtKitapName.Text = " ";
            txtAciklama.Text = " ";
            cmbDurum.SelectedIndex = -1;
            cmbTur.SelectedIndex = -1;
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label5.Text = turdt.Rows[cmbTur.SelectedIndex]["tid"].ToString();
        }
        
    }
    
}
