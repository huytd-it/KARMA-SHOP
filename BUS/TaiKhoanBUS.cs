using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
	public class TaiKhoanBUS
	{
		public static bool KTDangNhap(string tenTK, string mk)
		{
			if (!TaiKhoanDAO.KTTKTonTai(tenTK))
			{
				return false;
			}
			else
			{
				return mk == TaiKhoanDAO.LayMatKhau(tenTK);
			}
		}
        public static bool DangKi(TaiKhoanDTO tk)
        {
            if (TaiKhoanDAO.KTTKTonTai(tk.TenDangNhap))
            {
                return false;
            }
            else
            {
                return TaiKhoanDAO.ThemTK(tk);
            }
        }
        public static bool KTMatKhau(string mk1, string mk2)
        {
            if (mk1.Equals(mk2))
                return true;
            return false;
        }
	}
}
