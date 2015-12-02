using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace QLThuVien_TTN
{
    public class objDocGia
    {
        KetNoiDB con = new KetNoiDB();

        public DataTable HienThiBanDoc()
        {
            string sql = "SELECT * FROM DOCGIA";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void ThemBanDoc(string MaDG, string TenDG, string NgheNghiep, string SDT, string DiaChi)
        {
            string sql = "AddDG";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDG", MaDG);
            cmd.Parameters.AddWithValue("@TenDG", TenDG);
            cmd.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaBanDoc(string MaDG, string TenDG, string NgheNghiep, string SDT, string DiaChi)
        {
            string sql = "UpdateDG";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDG", MaDG);
            cmd.Parameters.AddWithValue("@TenDG", TenDG);
            cmd.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaBanDoc(string MaDG)
        {
            string sql = "DelDG";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDG", MaDG);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public DataTable TKDG_MaDG(string MaDG)
        {
            string sql = "SELECT * FROM DOCGIA WHERE MaDG LIKE N'%' + @MaDG + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaDG", MaDG);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }

        // Tìm kiếm tài liệu theo nhan đề
        public DataTable TKDG_TenDG(string TenDG)
        {
            string sql = "SELECT * FROM DOCGIA WHERE TenDG LIKE N'%' + @TenDG + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@TenDG", TenDG);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
