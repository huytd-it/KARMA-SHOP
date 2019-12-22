using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace GUI.Admin
{
    public partial class Chitietsp : System.Web.UI.Page
    {
        private int id;
        
        private string luutenanh;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Laythongtinsanpham();
               
            }
        }
        protected void Laythongtinsanpham()
        {
           id= Convert.ToInt32(Request.QueryString["id"]);
            DataRow dr = SanPhamBUS.Laythongtinsp(id);
          //loaisp = Convert.ToInt32(dr["loaisanpham"].ToString());
            luutenanh = dr["anhminhhoa"].ToString();
            txtTensp.Text = dr["tensanpham"].ToString();
            txtGiatien.Text = dr["giatien"].ToString();
            txtsoluong.Text = dr["soluongtonkho"].ToString();
            txtghichu.Text = dr["ghichu"].ToString();
            imgAnh.ImageUrl = "../img/product/" + dr["anhminhhoa"].ToString();
            hplanhct.NavigateUrl = "../img/product/" + dr["anhminhhoa"].ToString();
        }
        protected void Upload(object sender, EventArgs e)
        {
              luutenanh = fulanh.FileName;
            imgAnh.ImageUrl ="../img/product/" + fulanh.FileName;
            hplanhct.NavigateUrl = "../img/product/" + fulanh.FileName;
          
        }
        protected void UpDate(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            string anhupdate = fulanh.FileName;
            string Tensanpham = txtTensp.Text;
            int Giatien = Convert.ToInt32(txtGiatien.Text);
            int Soluongtonkho = Convert.ToInt32(txtsoluong.Text);
            string Ghichu = txtghichu.Text;
            int loaisp = 1;

            if (SanPhamBUS.Suathongtinsanpham(id, Tensanpham, anhupdate, Giatien, Soluongtonkho, Ghichu, loaisp))
            {
                pnlThongBao.Visible = true;
                pnlThongBao.GroupingText = "cập nhật thành công";
            }
            else
            {
                pnlThongBao.Visible = true;
                pnlThongBao.GroupingText = "cập nhật thất bại";
            }
        }
           
    }
}