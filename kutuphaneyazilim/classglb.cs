using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace kutuphaneyazilim
{
    class classglb
    {
        public int formdegeri = 0;
        public string kurumadi;
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=AHMETT\\SQLEXPRESS;Initial Catalog=kutuphane;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }

        public int komut(string sqlcumle)
        {
            SqlConnection baglanti = this.baglan();

            SqlCommand sorgu = new SqlCommand(sqlcumle,baglanti);
            int sonuc = 0;
            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message+"("+sqlcumle+")"+"hatası bulunmaktadır!");
            }
             sorgu.Dispose();
                baglanti.Dispose();
                baglanti.Close();
            return (sonuc);

        }

        public DataTable GetDataTable(string sqlcumle)
        {
            SqlConnection baglan = this.baglan();
            SqlDataAdapter da = new SqlDataAdapter(sqlcumle,baglan);

            DataTable dt = new DataTable();
            try
            {
                
            da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "(" + sqlcumle + ")" + "hatası bulunmaktadır!");
            }
            da.Dispose();
            baglan.Dispose();
            baglan.Close();
            return dt;

        }

        public DataRow GetDataRow(string sqlcumle)
        {
            DataTable table = GetDataTable(sqlcumle);
            if (table.Rows.Count == 0) return null;
            return table.Rows[0];
        }
        public string GetDataCell(string sqlcumle)
        {
            DataTable table = GetDataTable(sqlcumle);
            if (table.Rows.Count == 0) return null;
            return table.Rows[0][0].ToString();
        }

        public DataSet GetDataSet(string sqlcumle)
        {
            SqlConnection baglanti = this.baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcumle, baglanti);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message + "(" + sqlcumle + ")" + "hatası bulunmaktadır.");
            }
            adapter.Dispose();
            baglanti.Dispose();
            baglanti.Close();
            return ds;
        }

    }
}
