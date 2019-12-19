using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> DSSanPham()
        {
            return SanPhamDAO.LayDSSanPham();
        }
        public static List<SanPhamDTO> LocSP(Dictionary<string,string> sanpham)
        {
            List<string> sp = new List<string>();
            if (String.Compare(sanpham["tenHang"],"0")!=0 ||String.IsNullOrEmpty(sanpham["tenHang"]))
            {
                sp.Add("hangxe=" + sanpham["tenHang"]);
            }
            if (String.Compare(sanpham["tinhTrang"], "0") != 0 || String.IsNullOrEmpty(sanpham["tinhTrang"]))
            {
                sp.Add("trangthai= '" + sanpham["tinhTrang"]+ "'");
            }
            if (sanpham["giaTri"] != "0" || String.IsNullOrEmpty(sanpham["giaTri"]))
            {
                sp.Add("giatien" + ConvertToMoney(sanpham["giaTri"]));
            }
            if (String.Compare(sanpham["namSXLower"], "0") != 0 || String.IsNullOrEmpty(sanpham["namSXLower"]))
            {
                sp.Add("namsx >=" + sanpham["namSXLower"]);
            }
            if (String.Compare(sanpham["namSXUpper"], "0") != 0 || String.IsNullOrEmpty(sanpham["namSXUpper"]))
            {
                sp.Add("namsx <= " + sanpham["namSXUpper"]);
            }
            if (sanpham["hopSo"] != "0"||String.IsNullOrWhiteSpace(sanpham["hopSo"])||String.IsNullOrEmpty(sanpham["hopSo"]))
            {
                sp.Add("ghichu like N'" + sanpham["hopSo"]+"'");
            }
            string where = "Where xe.trangthai = 1 AND hangxe.id = xe.hangxe And " + String.Join(" AND ", sp);
            //Truyền chuổi rỗng khi không có điều kiện
            if (sp.Count <= 0)
                where = "";         
            return SanPhamDAO.LayDSSanPham(where);

        }
        public static string ConvertToMoney(string money)
        {
            switch (money)
            {
                case "1":
                    return ">= 1000000000";
                case "2":
                    return "<= 1000000000";
                case "3":
                    return ">= 800000000";
                case "4":
                    return "<= 800000000";
                case "5":
                    return ">= 600000000";
                case "6":
                    return "<= 600000000";
                case "7":
                    return ">= 400000000";
                case "8":
                    return "<= 400000000";       
                default:
                    return ">= 0";
            }
        }

        public static List<SanPhamDTO> DSSanPham(int limit,int start)
        {
            return SanPhamDAO.LayDSSanPham("where soluongtonkho > 0 and xe.trangthai = 1 AND hangxe.id = xe.hangxe order by id offset " + start+" rows fetch next " + limit + " rows only");
        }
    }
}
