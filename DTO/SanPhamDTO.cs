using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private int m_id;

        public int id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        private string m_ten;

        public string ten
        {
            get { return m_ten; }
            set { m_ten = value; }
        }
        private int m_idLoai;

        public int idLoai
        {
            get { return m_idLoai; }
            set { m_idLoai = value; }
        }
        private int m_giaTien;

        public int giaTien
        {
            get { return m_giaTien; }
            set { m_giaTien = value; }
        }
        private string m_anhMinhHoa;

        public string anhMinhHoa
        {
            get { return m_anhMinhHoa; }
            set { m_anhMinhHoa = value; }
        }
        private int m_soLuongTonKho;

        public int soLuongTonKho
        {
            get { return m_soLuongTonKho; }
            set { m_soLuongTonKho = value; }
        }
        private string m_ghichu;

        public string ghichu
        {
            get { return m_ghichu; }
            set { m_ghichu = value; }
        }
        private int m_KhoiLuong;

        public int KhoiLuong
        {
            get { return m_KhoiLuong; }
            set { m_KhoiLuong = value; }
        }
        private int m_KichCo;

        public int KichCo
        {
            get { return m_KichCo; }
            set { m_KichCo = value; }
        }
        private int m_DungTichXang;

        public int DungTichXang
        {
            get { return m_DungTichXang; }
            set { m_DungTichXang = value; }
        }
        private int m_KichCoLopXe;

        public int KichCoLopXe
        {
            get { return m_KichCoLopXe; }
            set { m_KichCoLopXe = value; }
        }
        private string m_LoaiDongco;

        public string LoaiDongco
        {
            get { return m_LoaiDongco; }
            set { m_LoaiDongco = value; }
        }
        private string m_DuongKinhHanhTrinhPitTong;

        public string DuongKinhHanhTrinhPitTong
        {
            get { return m_DuongKinhHanhTrinhPitTong; }
            set { m_DuongKinhHanhTrinhPitTong = value; }
        }
    }
}
