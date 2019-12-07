using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public static KhachHangDTO LayThongTinKhachHang(string TenTaiKhoan)
        {
            string query = "Select * From KhachHang Where TenTaikHoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", TenTaiKhoan);
            return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
        }
    
        public static KhachHangDTO ConvertToDTO(DataRow dr)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.Id = Convert.ToInt32(dr["id"]);
            kh.TenKhachHang = dr["HoTen"].ToString();
            kh.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
            kh.SDT = dr["Sdt"].ToString();
            kh.GioiTinh = Convert.ToBoolean(dr["GioiTinh"]);
            kh.Email = dr["Email"].ToString();
            kh.DiaChi = dr["Diachi"].ToString();
            kh.Trangthai = Convert.ToBoolean(dr["TrangThai"]);
            kh.GhiChu = dr["GhiChu"].ToString();
            kh.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            return kh;

        }
    }
}
