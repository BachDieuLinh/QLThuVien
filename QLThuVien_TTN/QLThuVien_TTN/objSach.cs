using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLThuVien_TTN
{
    class objSach
    {
        
        public DataTable HienThiSach()
        {
            string str = "Sho_Sach";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(str, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        
        public void ThemSach(string MaSach,string TenSach, string TheLoai, string NoiDung, string TacGia, string NXB)
        {
            string str = "ADD1_Sach";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@TheLoai", TheLoai);
            cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@NXB", NXB);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void SuaSach(string MaSach, string TenSach, string TheLoai, string NoiDung, string TacGia, string NXB)
        {
            string str = "UPD_Sach";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            cmd.Parameters.AddWithValue("@TheLoai", TheLoai);
            cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            cmd.Parameters.AddWithValue("@NXB", NXB);
            //cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
        }
        public void XoaSach(string MaSach)
        {
            string str = "Del_Sach";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.Dispose();
            con.Close();
        }

        public DataTable TimKiem_MaSach(String MaSach)
        {
            string str = "Sea_MaSach";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaSach", MaSach);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
            //   cmd.Dispose();
            //  con.Close();

        }
        public DataTable TimKiem_NXB(String NXB )
        {
            string str = "Sea_NXB";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str,con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NXB", NXB);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
         //   cmd.Dispose();
          //  con.Close();

        }

        public DataTable TimKiem_TenSach(String TenSach)
        {
            string str = "Sea_TenSach";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenSach", TenSach);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
            //   cmd.Dispose();
            //  con.Close();

        }
        public DataTable TimKiem_TheLoai(String TheLoai)
        {
            string str = "Sea_TheLoai";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TheLoai", TheLoai);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
            //   cmd.Dispose();
            //  con.Close();

        }
        public DataTable TimKiem_NoiDung(String NoiDung)
        {
            string str = "Sea_NoiDung";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
            //   cmd.Dispose();
            //  con.Close();

        }
        public DataTable TimKiem_TacGia(String TacGia)
        {
            string str = "Sea_TacGia";
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
            //   cmd.Dispose();
            //  con.Close();

        }
        
    }
}
