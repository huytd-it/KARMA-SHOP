using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> DSSanPham()
        {
            return SanPhamDAO.LayDSSanPham();
        }
    }
}
