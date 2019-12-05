using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangTinDTO
    {
        private int id;
        private int id_nguoiDang;
        
        private string hangCheTao;
        private string doiXe;
        private int namSanXuat;
        private string xuatXu;
        private string tinhTrang;
        private string dongXe;
        private int giaTien;
        private int soKm;

        public BangTinDTO()
        {
            this.hangCheTao = "";
            this.doiXe = "";
            this.NamSanXuat = 2019;
            this.xuatXu = "";
            this.tinhTrang = " ";
            this.giaTien = 0;
            this.soKm = 0;
            this.dongXe = "";

        }
        public string HangCheTao
        {
            get
            {
                return hangCheTao;
            }

            set
            {
                hangCheTao = value;
            }
        }

        public string DoiXe
        {
            get
            {
                return doiXe;
            }

            set
            {
                doiXe = value;
            }
        }

   
        public string XuatXu
        {
            get
            {
                return xuatXu;
            }

            set
            {
                xuatXu = value;
            }
        }

        public string TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }

        public int GiaTien
        {
            get
            {
                return giaTien;
            }

            set
            {
                giaTien = value;
            }
        }

        public int SoKm
        {
            get
            {
                return soKm;
            }

            set
            {
                soKm = value;
            }
        }

       
        public string DongXe
        {
            get
            {
                return dongXe;
            }

            set
            {
                dongXe = value;
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

        public int Id_nguoiDang
        {
            get
            {
                return id_nguoiDang;
            }

            set
            {
                id_nguoiDang = value;
            }
        }

        public int NamSanXuat
        {
            get
            {
                return namSanXuat;
            }

            set
            {
                namSanXuat = value;
            }
        }
    }
}
