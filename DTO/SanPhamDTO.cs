using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string tensanpham;

        public string Tensanpham
        {
            get { return tensanpham; }
            set { tensanpham = value; }
        }
        private string anhminhhoa;

        public string Anhminhhoa
        {
            get { return anhminhhoa; }
            set { anhminhhoa = value; }
        }
        private int giatien;

        public int Giatien
        {
            get { return giatien; }
            set { giatien = value; }
        }
        private int soluongtonkho;

        public int Soluongtonkho
        {
            get { return soluongtonkho; }
            set { soluongtonkho = value; }
        }
        private bool trangthai;

        public bool Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        private string ghichu;

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        private int loaisanpham;

        public int Loaisanpham
        {
            get { return loaisanpham; }
            set { loaisanpham = value; }
        }
        private int hangxe;

        public int Hangxe
        {
            get { return hangxe; }
            set { hangxe = value; }
        }
    }
}
