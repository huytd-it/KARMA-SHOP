using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
		public static string LayMatKhau(string tenTK)
		{
			string query = "SELECT MatKhau FROM TaiKhoan WHERE TENDANGNHAP = @TenTaiKhoan";
			SqlParameter[] param = new SqlParameter[1];
			param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
			return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
		}
	}
}
