using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangXeDTO
    {
        private int id;
        private string  tenHang;
        private string diaChi;
        private bool trangThai;
        private string ghiChu;

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public bool TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public HangXeDTO()
        {
            this.TenHang = "";
            this.DiaChi = "";
            this.GhiChu = "";
            this.TrangThai = true;
        }

    }
}
