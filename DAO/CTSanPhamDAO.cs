using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class CTSanPhamDAO
    {
        public static bool KTCTSanPham(int id)
        {
            string query = "select Count(*) from CT_XE where idxe = @id_xe";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_xe", id);
            return Convert.ToInt32( DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        public static CTSanPhamDTO Chitiet(int id)
        {
            string query = "select * from CT_XE where CT_XE.idxe = @id_xe ";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_xe", id);
                return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
        }
        public static CTSanPhamDTO ConvertToDTO(DataRow dr)
        {
            CTSanPhamDTO ct = new CTSanPhamDTO();
            ct.Khoiluong = dr["khoiluong"].ToString();
            ct.Dai_rong_cao = dr["dai_rong_cao"].ToString();
            ct.Dungtichxang = dr["dungtichxang"].ToString();
            ct.Lopxe = dr["kichcolopxe"].ToString();
            ct.Loaidongco = dr["loaidongco"].ToString();
            ct.D_hanhtrinhpittong = dr["d_hanhtrinhpitong"].ToString();
            ct.Tysonen = dr["tysonen"].ToString();
            ct.Congsuat = dr["congsuat"].ToString();
            ct.Momencucdai = dr["momencucdai"].ToString();
            ct.Dungtichnhot = dr["dungtichnhot"].ToString();
            ct.Loaitruyendong = dr["loaitruyendong"].ToString();

            return ct;
        }

        public static SanPhamDTO LaySP(int id)
        {
            string queryString = "select * from XE where id = @id";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", id);
            return ConvertToDTOSP(DataProvider.ExecuteSelectQuery(queryString, param).Rows[0]);
        }

        public static SanPhamDTO ConvertToDTOSP(DataRow dr)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.Anhminhhoa = dr["anhminhhoa"].ToString();
            sp.Tensanpham = dr["tensanpham"].ToString();
            sp.Giatien = Convert.ToInt32(dr["giatien"].ToString());
            return sp;

        }

    }
}
