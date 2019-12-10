using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private int m_id;
        private string m_tenKhachHang;
        private string m_diaChi;
        private DateTime m_ngaySinh;
        private string m_email;
        private string m_SDT;
        private bool m_trangthai;
        private string m_ghiChu;
        private string m_tenTaiKhoan;


        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
       

        public string TenKhachHang
        {
            get { return m_tenKhachHang; }
            set { m_tenKhachHang = value; }
        }
        

        public string DiaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }
     

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
       
        public string Email
        {
            get { return m_email; }
            set { m_email = value; }
        }
       

        public string SDT
        {
            get { return m_SDT; }
            set { m_SDT = value; }
        }

        public bool Trangthai
        {
            get
            {
                return m_trangthai;
            }

            set
            {
                m_trangthai = value;
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
    }
}
