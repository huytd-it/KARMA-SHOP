using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class KhachHangDTO
    {
        private int m_id;

        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        private string m_tenKhachHang;

        public string TenKhachHang
        {
            get { return m_tenKhachHang; }
            set { m_tenKhachHang = value; }
        }
        private string m_diaChi;

        public string DiaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }
        private DateTime m_ngaySinh;

        public DateTime NgaySinh
        {
            get { return m_ngaySinh; }
            set { m_ngaySinh = value; }
        }
        private bool m_gioiTinh;

        public bool GioiTinh
        {
            get { return m_gioiTinh; }
            set { m_gioiTinh = value; }
        }
        private string m_email;

        public string Email
        {
            get { return m_email; }
            set { m_email = value; }
        }
        private string m_SDT;

        public string SDT
        {
            get { return m_SDT; }
            set { m_SDT = value; }
        }

    }
}
