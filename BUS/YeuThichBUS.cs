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
                return false;
            }
            else
            {
                return YeuThichDAO.Themyeuthich(YT);
            }
        }
    }
}
