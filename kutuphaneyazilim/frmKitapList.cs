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
using System.Diagnostics;
using System.IO;

namespace kutuphaneyazilim
{
    public partial class frmKitapList : Form
    {
        classglb clsfile = new classglb();
       
        public frmKitapList(frmMain Parent)
        {
            InitializeComponent();
            KitapList();
        }

        private void KitapList()
        {
            DataTable dt = clsfile.GetDataTable("Select kb.kid,kb.kitapAdi,di.durumAdi,ti.turadi,kb.aciklama from tblKitapBilgisi kb,tblTurBlgs ti,tblDurumBlgs di where di.durumid=kb.durumid and ti.tid=kb.turid");
//DataRow dr=dt.Rows[i];
                
            
                dtGrKitapLst.DataSource=dt;
                dtGrKitapLst.Columns["kid"].HeaderText = "Kitap ID";
                dtGrKitapLst.Columns["kitapAdi"].HeaderText = "Kitap ADI";
                dtGrKitapLst.Columns["durumAdi"].HeaderText = "Kitap Nerede";
                dtGrKitapLst.Columns["turadi"].HeaderText = "Kitap Türü";
                dtGrKitapLst.Columns["aciklama"].HeaderText = "Açıklama";

            
        }

        private void cmbKitapFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbKitapFiltre.SelectedIndex != 3)
            {
                DataTable dt = clsfile.GetDataTable("Select kb.kid,kb.kitapAdi,di.durumAdi,ti.turadi,kb.aciklama from tblKitapBilgisi kb,tblTurBlgs ti,tblDurumBlgs di where di.durumid=kb.durumid and ti.tid=kb.turid and kb.durumid=" + Convert.ToInt32(cmbKitapFiltre.SelectedIndex.ToString()) + "");

                dtGrKitapLst.DataSource = dt;
                dtGrKitapLst.Columns["kid"].HeaderText = "Kitap ID";
                dtGrKitapLst.Columns["kitapAdi"].HeaderText = "Kitap ADI";
                dtGrKitapLst.Columns["durumAdi"].HeaderText = "Kitap Nerede";
                dtGrKitapLst.Columns["turadi"].HeaderText = "Kitap Türü";
                dtGrKitapLst.Columns["aciklama"].HeaderText = "Açıklama";
            }

            else
                KitapList();
               
            
        }
    }
}
