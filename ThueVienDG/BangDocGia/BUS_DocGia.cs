using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using KetNoi;

namespace BangDocGia
{
    public class BUS_DocGia
    {
        Connection cn = new Connection();

        public DataTable HienThiBanDoc()
        {
            string sql = "SELECT * FROM DOCGIA";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Connection.connect());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        public void ThemBanDoc(string MaDG, string TenDG, string NgheNghiep, string SDT, string DiaChi)
        {
            string sql = "AddDG";
            SqlConnection con = new SqlConnection(Connection.connect());
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
            SqlConnection con = new SqlConnection(Connection.connect());
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
            SqlConnection con = new SqlConnection(Connection.connect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDG", MaDG);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
