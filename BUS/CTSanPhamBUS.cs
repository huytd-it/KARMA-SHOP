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
        public static CTSanPhamDTO XemChiTiet(int id){
           if(CTSanPhamDAO.KTCTSanPham(id))
           {
               return CTSanPhamDAO.Chitiet(id);
           }
           return null;    
        }

        public static SanPhamDTO LaySP(int id)
        {
            return CTSanPhamDAO.LaySP(id);
        }
    }
}
