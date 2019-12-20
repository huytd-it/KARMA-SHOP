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

        public static List<SanPhamDTO> LayDSYeuthich(string session)
        {
            string querydsyt = "select Xe.anhminhhoa,Xe.tensanpham,Xe.giatien,Xe.id from XE,GioHang where Xe.id = GioHang.Maxe and Tentaikhoan =@TK and Xoa = 0";
            SqlParameter[] paramdsyt = new SqlParameter[1];
            paramdsyt[0] = new SqlParameter("@TK", session);
            DataTable TableDSYT = DataProvider.ExecuteSelectQuery(querydsyt, paramdsyt);
            List<SanPhamDTO> litDSYT = new List<SanPhamDTO>();
            if (TableDSYT != null)
            {
                foreach(DataRow dr in TableDSYT.Rows)
                {
                    litDSYT.Add(ConvertDTO(dr));
                }
            }
            return litDSYT;

        }

        public static SanPhamDTO ConvertDTO(DataRow dr)
        {
            SanPhamDTO dsyt = new SanPhamDTO();
            dsyt.Tensanpham = dr["tensanpham"].ToString();
            dsyt.Anhminhhoa = dr["anhminhhoa"].ToString();
            dsyt.Giatien = Convert.ToInt32(dr["giatien"].ToString());
            dsyt.Id =  Convert.ToInt32(dr["id"].ToString());
            return dsyt;
        }

        public static bool CapNhat(YeuThichDTO YT)
        {
            string queryCN = "update GioHang set Xoa = 0 where Maxe = @IdXe and Tentaikhoan = @TK";
            SqlParameter[] paramCN = new SqlParameter[2];
            paramCN[0] = new SqlParameter("@TK", YT.Tendangnhap1);
            paramCN[1] = new SqlParameter("@idxe ", YT.MaXe1);
            return Convert.ToInt32(DataProvider.ExecuteUpdateQuery(queryCN, paramCN)) == 1;
        }

        public static bool Xoa(YeuThichDTO YT)
        {
            string queryX = "update GioHang set Xoa = 1 where Maxe = @IdXe and Tentaikhoan = @TK";
            SqlParameter[] paramX = new SqlParameter[2];
            paramX[0] = new SqlParameter("@TK", YT.Tendangnhap1);
            paramX[1] = new SqlParameter("@idxe ", YT.MaXe1);
            return Convert.ToInt32(DataProvider.ExecuteUpdateQuery(queryX, paramX)) == 1;
        }
    }
}
