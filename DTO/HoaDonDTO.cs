using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDonDTO
    {
		private int m_id;
		private string m_tenTaiKhoan;
		private DateTime m_ngayMua;
		private string m_diaChiGiaoHang;
		string m_ghiChu;
		int m_tongTien;

		public int ID
		{
			get
			{
				return m_id;
			}

			set
			{
				m_id = value;
			}
		}

		public string TenTaiKhoan
		{
			get
			{
				return m_tenTaiKhoan;
			}

			set
			{
				m_tenTaiKhoan = value;
			}
		}

		public DateTime NgayMua
		{
			get
			{
				return m_ngayMua;
			}

			set
			{
				m_ngayMua = value;
			}
		}

		public string DiaChiGiaoHang
		{
			get
			{
				return m_diaChiGiaoHang;
			}

			set
			{
				m_diaChiGiaoHang = value;
			}
		}

		public string GhiChu
		{
			get
			{
				return m_ghiChu;
			}

			set
			{
				m_ghiChu = value;
			}
		}

		public int TongTien
		{
			get
			{
				return m_tongTien;
			}

			set
			{
				m_tongTien = value;
			}
		}
	}
}
