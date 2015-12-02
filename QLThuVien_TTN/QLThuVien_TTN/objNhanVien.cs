using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLThuVien_TTN
{
    class objNhanVien
    {
        KetNoiDB con = new KetNoiDB();
        public DataTable HienThiNhanVien()
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(KetNoiDB.KetNoi());
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}
