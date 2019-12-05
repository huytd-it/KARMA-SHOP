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
    public class HangXeDAO
    {
        public static List<HangXeDTO> LayDS()
        {
            string query = "Select * from HangXe";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbHangXe = DataProvider.ExecuteSelectQuery(query, param);

            List<HangXeDTO> hx = new List<HangXeDTO>();
            foreach(DataRow dr in dtbHangXe.Rows)
            {
                hx.Add(ConvertToDTO(dr));
            }
            return hx;
        }
        public static HangXeDTO ConvertToDTO(DataRow dr)
        {
            HangXeDTO hx = new HangXeDTO();
            hx.Id = Convert.ToInt32(dr["id"]);
            hx.TenHang = dr["TenHanhXe"].ToString();
            hx.DiaChi = dr["DiaChi"].ToString();
            hx.GhiChu = dr["GhiChu"].ToString();
            hx.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return hx;
        }
    }
}
