using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

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
	}
}
