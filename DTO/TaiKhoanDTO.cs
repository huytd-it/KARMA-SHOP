using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string m_tenDangNhap;

        public string TenDangNhap
        {
            get { return m_tenDangNhap; }
            set { m_tenDangNhap = value; }
        }
        private string m_matKhau;

        public string MatKhau
        {
            get { return m_matKhau; }
            set { m_matKhau = value; }
        }
    }
}
