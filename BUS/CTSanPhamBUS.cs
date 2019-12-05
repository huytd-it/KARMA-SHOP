using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class CTSanPhamBUS
    {
        public static DataRow LayDSCTSanPham(int id_xe)
        {
            return CTSanPhamDAO.LayCTSanPham(id_xe);
        }
    }
}
