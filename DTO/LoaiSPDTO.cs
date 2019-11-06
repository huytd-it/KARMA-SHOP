using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LoaiSPDTO
    {
        private int m_ID;
        private string m_tenLoai;
        private bool m_Xoa;
        private string m_ghiChu;

		public int ID
		{
			get
			{
				return m_ID;
			}

			set
			{
				m_ID = value;
			}
		}

		public string TenLoai
		{
			get
			{
				return m_tenLoai;
			}

			set
			{
				m_tenLoai = value;
			}
		}

		public bool Xoa
		{
			get
			{
				return m_Xoa;
			}

			set
			{
				m_Xoa = value;
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
