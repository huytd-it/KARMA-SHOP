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

        public bool La_admin
        {
            get
            {
                return la_admin;
            }

            set
            {
                la_admin = value;
            }
        }
        private bool la_admin;
        private string m_email;
        public TaiKhoanDTO()
        {
            this.m_email = " ";
            this.m_matKhau = " ";
            this.m_tenDangNhap = " ";
            this.la_admin = false;
        }
    }
}
