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
    public class SanPhamDAO
    {
        public static List<SanPhamDTO> LayDSSanPham()
        {
            string query = "select * from Xe where soluongtonkho > 0 and trangthai = 1";
            SqlParameter[] para = new SqlParameter[0];
            DataTable dtbXe = DataProvider.ExecuteSelectQuery(query, para);
            List<SanPhamDTO> lstXe = new List<SanPhamDTO>();
            foreach (DataRow dr in dtbXe.Rows)
            {
                lstXe.Add(ConvertToDTO(dr));
            }
            return lstXe;
        }
        
        public static List<SanPhamDTO> LayDSSanPham(string where)
        {
            string query = "select * from Xe " + where;
            SqlParameter[] para = new SqlParameter[0];
            DataTable dtbXe = DataProvider.ExecuteSelectQuery(query, para);
            List<SanPhamDTO> lstXe = new List<SanPhamDTO>();
            if(dtbXe != null)
                foreach (DataRow dr in dtbXe.Rows)
                {
                    lstXe.Add(ConvertToDTO(dr));
                }
            return lstXe;
        }
        
        public static SanPhamDTO ConvertToDTO(DataRow dr)
        {
            SanPhamDTO xe = new SanPhamDTO();
            xe.Id = Convert.ToInt32(dr["id"]);
            xe.Tensanpham = dr["tensanpham"].ToString();
            xe.Anhminhhoa = dr["anhminhhoa"].ToString();
            xe.Giatien = Convert.ToInt32(dr["giatien"].ToString());
            xe.Soluongtonkho = Convert.ToInt32(dr["soluongtonkho"]);
            xe.Trangthai = Convert.ToBoolean(dr["trangthai"]);
            xe.Ghichu = dr["ghichu"].ToString();
            xe.Loaisanpham = Convert.ToInt32(dr["loaisanpham"]);
            xe.Hangxe = Convert.ToInt32(dr["hangxe"]);
            return xe;
        }

    }
}
