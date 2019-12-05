using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
	public class TaiKhoanDAO
	{
		public static object SqlParamter { get; private set; }

		public static bool KTTKTonTai(string tenTK)
		{
			string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENDANGNHAP = @TenTaiKhoan";
			SqlParameter[] param = new SqlParameter[1];
			param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
			return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
		}

        //Lấy thông tin tài khoản từ database
        public static TaiKhoanDTO LayThongTinTaiKhoan(string TenDangNhap)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE TENDANGNHAP=@tendangnhap";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@tendangnhap", TenDangNhap);
            return ConvertToDTO(DataProvider.ExecuteSelectQuery(query,param).Rows[0]);
        }
		public static string LayMatKhau(string tenTK)
		{
			string query = "SELECT MatKhau FROM TaiKhoan WHERE TENDANGNHAP = @TenTaiKhoan";
			SqlParameter[] param = new SqlParameter[1];
			param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
			return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
		}
        public static bool ThemTK(TaiKhoanDTO tk)
        {
            string query = "INSERT INTO TaiKhoan (tendangnhap,matkhau,email,la_admin) VALUES (@tendangnhap,@matkhau,@email,@la_admin)";
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@tendangnhap", tk.TenDangNhap);
            param[1] = new SqlParameter("@matkhau", tk.MatKhau);
            param[2] = new SqlParameter("@email", tk.Email);
            param[3] = new SqlParameter("@la_admin", tk.La_admin);
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }
        //Chuyển sang kiểu DTO
        public static TaiKhoanDTO ConvertToDTO(DataRow dr)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenDangNhap = dr["TenDangNhap"].ToString();
            tk.MatKhau = dr["MatKhau"].ToString();
            tk.Email = dr["Email"].ToString();
            tk.La_admin = Convert.ToBoolean("LaAdmin");
            return tk;

        }
	}
}
