using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
		private int m_id;
		private string m_hoVaTen;
		private DateTime m_ngaySinh;
		private string m_email;
		private int m_SDT;
		private string m_diaChi;
		private DateTime m_ngayVaoLam;
		private int m_luong;
		private bool m_xoa;
		private string m_ghiChu;

		public int Id
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

		public string HoVaTen
		{
			get
			{
				return m_hoVaTen;
			}

			set
			{
				m_hoVaTen = value;
			}
		}

		public DateTime NgaySinh
		{
			get
			{
				return m_ngaySinh;
			}

			set
			{
				m_ngaySinh = value;
			}
		}

		public string Email
		{
			get
			{
				return m_email;
			}

			set
			{
				m_email = value;
			}
		}

		public int SDT
		{
			get
			{
				return m_SDT;
			}

			set
			{
				m_SDT = value;
			}
		}

		public string DiaChi
		{
			get
			{
				return m_diaChi;
			}

			set
			{
				m_diaChi = value;
			}
		}

		public DateTime NgayVaoLam
		{
			get
			{
				return m_ngayVaoLam;
			}

			set
			{
				m_ngayVaoLam = value;
			}
		}

		public int Luong
		{
			get
			{
				return m_luong;
			}

			set
			{
				m_luong = value;
			}
		}

		public bool Xoa
		{
			get
			{
				return m_xoa;
			}

			set
			{
				m_xoa = value;
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
	}
}
