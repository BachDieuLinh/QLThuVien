using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KetNoi;

namespace BangDocGia
{
    public class TimKiem
    {
        Connection cn = new Connection();
        public DataTable TKDG_MaDG(string MaDG)
        {
            string sql = "SELECT * FROM DOCGIA WHERE MaDG LIKE N'%' + @MaDG + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Connection.connect());
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
            SqlConnection con = new SqlConnection(Connection.connect());
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
