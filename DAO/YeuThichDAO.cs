using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class YeuThichDAO
    {
        public static bool KTTontai(YeuThichDTO YT)
        {
            string querykt = "select count(*) from GioHang where Maxe = @Masp and Tentaikhoan =@Tentaikhoan";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Masp", YT.MaXe1);
            param[1] = new SqlParameter("@Tentaikhoan", YT.Tendangnhap1);
            return Convert.ToInt32( DataProvider.ExecuteSelectQuery(querykt, param).Rows[0][0]) == 1 ;
        }

        public static bool Themyeuthich(YeuThichDTO YT)
        {
            string querytyt = "Insert into GioHang (Maxe,Tentaikhoan) values (@Masp,@Tentaikhoan)";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Masp", YT.MaXe1);
            param[1] = new SqlParameter("@Tentaikhoan", YT.Tendangnhap1);
            return DataProvider.ExecuteInsertQuery(querytyt, param) == 1;
        }
    }
}
