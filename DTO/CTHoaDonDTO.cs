using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CTHoaDonDTO
    {
		private int m_idHoaDon;
		private int m_IdSanPham;
		private int m_soLuong;
		private int m_dongGia;

		public int IdHoaDon
		{
			get
			{
				return m_idHoaDon;
			}

			set
			{
				m_idHoaDon = value;
			}
		}

		public int IdSanPham
		{
			get
			{
				return m_IdSanPham;
			}

			set
			{
				m_IdSanPham = value;
			}
		}

		public int SoLuong
		{
			get
			{
				return m_soLuong;
			}

			set
			{
				m_soLuong = value;
			}
		}

		public int DongGia
		{
			get
			{
				return m_dongGia;
			}

			set
			{
				m_dongGia = value;
			}
		}
	}
}
