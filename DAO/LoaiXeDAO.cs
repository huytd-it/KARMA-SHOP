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
    public class LoaiXeDAO
    {
        public static List<LoaiXeDTO> LayDSLoaiXe()
        {
            string query = "Select * from LoaiXe";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtb = DataProvider.ExecuteSelectQuery(query, param);
            List<LoaiXeDTO> listLoaiXe = new List<LoaiXeDTO>();
            foreach(DataRow dr in dtb.Rows)
            {
                listLoaiXe.Add(ConvertToDTO(dr));
            }
            return listLoaiXe;

        }
        public static LoaiXeDTO ConvertToDTO(DataRow dr)
        {
            LoaiXeDTO lx = new LoaiXeDTO();
            lx.Id =Convert.ToInt32(dr["Id"]);
            lx.TenLoai = dr["TenLoai"].ToString();
            lx.TrangThai =Convert.ToBoolean( dr["TrangThai"]);
            lx.GhiChu = dr["GhiChu"].ToString();
            return lx;
        }
    }
}
