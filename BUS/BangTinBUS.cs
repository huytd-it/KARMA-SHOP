using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class BangTinBUS
    {
        public static List<LoaiXeDTO> LayDSLoaiXe()
        {
            return LoaiXeDAO.LayDSLoaiXe();
        }
        public static List<HangXeDTO> LayDSHangXe()
        {
            return HangXeDAO.LayDS();
        }
        public static bool ThemTin(BangTinDTO bangtin)
        {
            return BangTinDAO.ThemBangTin(bangtin);
        }
    }
}
