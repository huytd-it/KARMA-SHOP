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
        
        private int hangCheTao;
        private int doiXe;
        private int namSanXuat;
        private string xuatXu;
        private string tinhTrang;
        private string dongXe;
        private int giaTien;
        private int soKm;

        public BangTinDTO()
        {
            this.HangCheTao = 0;
            this.DoiXe = 0;
            this.NamSanXuat = 2019;
            this.xuatXu = "";
            this.tinhTrang = " ";
            this.giaTien = 0;
            this.soKm = 0;
            this.dongXe = "";

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

        public int HangCheTao
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

        public int DoiXe
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
    }
}
