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
        public static DataRow LayCTSanPham(int id_xe)
        {
            string query = "select * from CT_XE where idxe = @id_xe";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_xe", id_xe);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0];
        }

    }
}
