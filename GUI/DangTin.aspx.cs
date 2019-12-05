using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
namespace GUI
{
    public partial class DangTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadLoaiXe();
            LoadNamSX();
            LoadHangXe();
            LoadDongXe();


        }
        protected void LoadLoaiXe()
        {
            ddlLoaiXe.DataSource = BangTinBUS.LayDSLoaiXe();
            ddlLoaiXe.DataTextField = "TenLoai";
            ddlLoaiXe.DataValueField = "Id";
            ddlLoaiXe.DataBind();
        }
        //Load Năm sản xuất
        protected void LoadNamSX()
        {            
            List<int> namsx = new List<int>();
           
            for(int i = DateTime.Now.Year; i >1999 ; i--)
            {
                namsx.Add(i);
            }
            ddlNamSX.DataSource = namsx;           
            ddlNamSX.DataBind();

        }
        protected void LoadHangXe()
        {
            ddlHangCheTao.DataSource = BangTinBUS.LayDSHangXe();
            ddlHangCheTao.DataTextField = "TenHang";
            ddlHangCheTao.DataValueField = "Id";
            ddlHangCheTao.DataBind();
        }
        protected void LoadDongXe()
        {
            List<string> ls_dongxe = new List<string> {"SUV", "Sedan", "Coupe", "Truck", "Van", "Wagon", "Crossover" };
            ddlDongXe.DataSource = ls_dongxe;
            ddlDongXe.DataBind();
        }
        protected void btnDangTin_Click(object sender, EventArgs e)
        {
            BangTinDTO bangtin = new BangTinDTO();

            bangtin.DoiXe = ddlLoaiXe.SelectedValue;
            bangtin.DongXe = ddlDongXe.SelectedValue;
            bangtin.HangCheTao = ddlHangCheTao.SelectedValue;
            bangtin.TinhTrang = ddlTinhTrang.SelectedValue;
            bangtin.NamSanXuat = Convert.ToInt32(ddlNamSX.SelectedValue);
            bangtin.XuatXu = ddlXuatXu.SelectedValue;
            

            bangtin.GiaTien = Convert.ToInt32(txtGiaTien.Text);
            bangtin.SoKm = Convert.ToInt32(txtSoKM.Text);

            if (BangTinBUS.ThemTin(bangtin))
            {
                pnlThongBao.Visible = true;
                pnlThongBao.GroupingText = "Đăng tin thành công";
                
            }
            else
            {
                Response.Write("<script>alert('Đăng tin thành công')</script>");
            }
        }
       
    }
}