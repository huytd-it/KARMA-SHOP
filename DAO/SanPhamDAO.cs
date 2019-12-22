using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        public static List<SanPhamDTO> LayDSSanPham()
        {
            string query = "select xe.*,hangxe.tenhanhxe from xe,hangxe  where soluongtonkho > 0 and xe.trangthai = 1 AND hangxe.id = xe.hangxe";
            SqlParameter[] para = new SqlParameter[0];
            DataTable dtbXe = DataProvider.ExecuteSelectQuery(query, para);
            List<SanPhamDTO> lstXe = new List<SanPhamDTO>();
            if(dtbXe != null)
            foreach (DataRow dr in dtbXe.Rows)
            {
                lstXe.Add(ConvertToDTO(dr));
            }
            return lstXe;
        }
        public static DataTable LayDSsanpham()
        {
            string query = "select xe.*,hangxe.tenhanhxe from xe,hangxe  where soluongtonkho > 0 and xe.trangthai = 1 AND hangxe.id = xe.hangxe";
            SqlParameter[] para = new SqlParameter[0];
            DataTable dtbXe = DataProvider.ExecuteSelectQuery(query, para);
            return dtbXe;
        }
        public static List<SanPhamDTO> LayDSSanPham(string where)
        {

            string query = "select xe.*,hangxe.tenhanhxe from xe,hangxe " + where;
            SqlParameter[] para = new SqlParameter[0];
            DataTable dtbXe = DataProvider.ExecuteSelectQuery(query, para);
            List<SanPhamDTO> lstXe = new List<SanPhamDTO>();
            if(dtbXe != null)
                foreach (DataRow dr in dtbXe.Rows)
                {
                    lstXe.Add(ConvertToDTO(dr));
                }
            return lstXe;
        }
        
        public static SanPhamDTO ConvertToDTO(DataRow dr)
        {
            SanPhamDTO xe = new SanPhamDTO();
            xe.Id = Convert.ToInt32(dr["id"]);
            xe.Tensanpham = dr["tensanpham"].ToString();
            xe.Anhminhhoa = dr["anhminhhoa"].ToString();
            xe.Giatien = Convert.ToInt32(dr["giatien"].ToString());
            xe.Soluongtonkho = Convert.ToInt32(dr["soluongtonkho"]);
            xe.Trangthai = Convert.ToBoolean(dr["trangthai"]);
            xe.Ghichu = dr["ghichu"].ToString();
            xe.Loaisanpham = Convert.ToInt32(dr["loaisanpham"]);
            xe.Hangxe = Convert.ToInt32(dr["hangxe"]);
            return xe;
        }
        //xoa san pham
        public static bool Destroy(int ID)
        {
            string query = "UPDATE xe set trangthai=0 Where id=@ID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", ID); 
            return DataProvider.ExecuteDeleteQuery(query,param)==1;
        }
        //khoi phuc san pham
        public static bool Restore(int ID)
        {
            string query = "UPDATE xe set trangthai=1 where id=@ID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", ID);
            return DataProvider.ExecuteDeleteQuery(query, param)==1;
        }
        //kiem tra ton tai cua san phan
        public static bool KTSanPhamTonTai(int ID)
        {
            string query = "Select count(*) from xe where id=@ID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", ID);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query,param).Rows[0][0])==1;
        }
        //load danh sach san pham bi xoa
        public static DataTable LayDSSanPhamXoa()
        {
            string query = "select xe.*,hangxe.tenhanhxe from xe,hangxe  where  xe.trangthai = 0 AND hangxe.id = xe.hangxe";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbXe = DataProvider.ExecuteSelectQuery(query, param);
            return dtbXe;
        }
        //lay thong tin cua 1 row
        public static DataRow Laythongtinsp(int id)
        {
            string query = "select * from xe where id=@id";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", id);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0];
        }
        //sua thong tin san pham 
        public static bool Suathongtinsanpham(int id,string tensp,string anhminhoa,int gia,int soluong,string ghichu,int loaixe)
        {
            string query = "UPDATE XE set tensanpham = @tensp, anhminhhoa = @anhminhhoa, giatien = @gia, soluongtonkho = @soluong, ghichu = @ghichu, loaisanpham = @loaixe WHERE id = @id";
            SqlParameter[] param=new SqlParameter[7];
            param[0]=new SqlParameter("@tensp",tensp);
            param[1]=new SqlParameter("@anhminhhoa",anhminhoa);
            param[2]=new SqlParameter("@gia",gia);
            param[3]=new SqlParameter("@soluong",soluong);
            param[4]=new SqlParameter("@ghichu",ghichu);
            param[5]=new SqlParameter("@loaixe",loaixe);
            param[6]=new SqlParameter("@id",id);
            return DataProvider.ExecuteUpdateQuery(query, param) == 1;
        }
    }
}
