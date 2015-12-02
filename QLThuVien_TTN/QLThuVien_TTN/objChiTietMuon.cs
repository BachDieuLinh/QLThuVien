using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLThuVien_TTN
{

    class objChiTietMuon
    {
        KetNoiDB con = new KetNoiDB();
        public DataTable HienThiChiTietMuon()
        {
            string sql = "SELECT * FROM CHITIETMUON";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void GhiChiTietMuon(string MaPhieu, string MaSach)
        {
            string str = "Ins_CTM";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
