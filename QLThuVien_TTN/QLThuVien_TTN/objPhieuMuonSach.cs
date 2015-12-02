using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLThuVien_TTN
{
    class objPhieuMuonSach
    {
        KetNoiDB con = new KetNoiDB();
        public DataTable HienThiPhieuMuon()
        {
            string sql = "SELECT * FROM PHIEUMUONSACH";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void GhiPhieuMuonSach(string MaPhieu, string MaDG, string MaNV, string NgayMuon, string NgayTra, int TinhTrang)
        {
            string str = "Ins_PM";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
            cmd.Parameters.AddWithValue("@MaDG", MaDG);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            cmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
            cmd.Parameters.AddWithValue("@NgayTra", NgayTra);
            cmd.Parameters.AddWithValue("@TinhTrang", TinhTrang);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
