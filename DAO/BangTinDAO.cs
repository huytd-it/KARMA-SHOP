using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BangTinDAO
    {
        public static List<BangTinDTO> LayDSBangTin()
        {
            string query = "select * from tindang";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtBangTin = DataProvider.ExecuteSelectQuery(query, param);
            
            List<BangTinDTO> ls_bangtin = new List<BangTinDTO>();
            foreach(DataRow dr in dtBangTin.Rows)
            {
                ls_bangtin.Add(ConvertToDTO(dr));
            }
            return ls_bangtin;
        }
        public static bool ThemBangTin(BangTinDTO bangTin)
        {
            string query
                = "insert into tindang(id_nguoidang,hangxe,dongxe,doixe,giatien,sokm,tinhtrang,xuatxu,namsx)"
                + "values(@id_nguoidang,@hangxe,@dongxe,@doixe,@giatien,@sokm,@tinhtrang,@xuatxu,@namsx)";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@id_nguoidang", bangTin.Id_nguoiDang);
            param[1] = new SqlParameter("@hangxe", bangTin.HangCheTao);
            param[2] = new SqlParameter("@doixe", bangTin.DoiXe);
            param[3] = new SqlParameter("@dongxe", bangTin.DongXe);
            param[4] = new SqlParameter("@giatien", bangTin.GiaTien);
            param[5] = new SqlParameter("@sokm", bangTin.SoKm);
            param[6] = new SqlParameter("@tinhtrang", bangTin.TinhTrang);
            param[7] = new SqlParameter("@xuatxu", bangTin.XuatXu);
            param[8] = new SqlParameter("@namsx", bangTin.NamSanXuat);
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
           
        }
        public static BangTinDTO ConvertToDTO(DataRow dr)
        {
            BangTinDTO bt = new BangTinDTO();
            bt.Id = Convert.ToInt32(dr["id"]);
            bt.Id_nguoiDang = Convert.ToInt32(dr["id_nguoidang"]);
            bt.TinhTrang = dr["tinhtrang"].ToString();
            bt.XuatXu = dr["XuatXu"].ToString();
            bt.DoiXe = dr["Doixe"].ToString();
            bt.DongXe = dr["Dongxe"].ToString();
            bt.HangCheTao = dr["Hangxe"].ToString();
            bt.GiaTien = Convert.ToInt32(dr["Giatien"]);
            bt.SoKm = Convert.ToInt32(dr["SoKm"]);
            bt.NamSanXuat = Convert.ToInt32(dr["NamSX"]);
            
            return bt;
        }
    }
}
