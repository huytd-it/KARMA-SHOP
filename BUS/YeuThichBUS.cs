using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class YeuThichBUS
    {
        public static bool ThemYT(YeuThichDTO YT)
        {
            if (YeuThichDAO.KTTontai(YT))
            {
                return YeuThichDAO.CapNhat(YT);
            }
            else
            {
                return YeuThichDAO.Themyeuthich(YT);
            }
        }

        public static List<SanPhamDTO> DsSanphamYT(string session)
        {
            return YeuThichDAO.LayDSYeuthich(session);
        }

        public static bool Xoa(YeuThichDTO YT)
        {
            return YeuThichDAO.Xoa(YT);
        }
    }
}
