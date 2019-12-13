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
            if (!IsPostBack)
            {
                LoadLoaiXe();
                LoadNamSX();
                LoadHangXe();
                LoadDongXe();
            }
      


        }
        
        //Load Loại xe
        protected void LoadLoaiXe()
        {
            //List<LoaiXeDTO> ls_loaixe = new List<LoaiXeDTO>();
            //LoaiXeDTO lx = new LoaiXeDTO();
           
            //lx.TenLoai = "--Chọn--";
            //ls_loaixe.Add(lx);
            //foreach(LoaiXeDTO lx_in_ls in BangTinBUS.LayDSLoaiXe())
            //{
            //    ls_loaixe.Add(lx_in_ls);
            //}

            ddlLoaiXe.DataSource = BangTinBUS.LayDSLoaiXe();
            ddlLoaiXe.DataTextField = "TenLoai";
            ddlLoaiXe.DataValueField = "Id";
            ddlLoaiXe.DataBind();
            
            ddlLoaiXe.Items.Insert(0, new ListItem("--Chọn--", "0"));
            ddlLoaiXe.SelectedIndex = 0;
        }
        //Load Năm sản xuất
        protected void LoadNamSX()
        {
            List<ListItem> namsx = new List<ListItem>();
           
            for (int i = 19; i > 0; i--)
            {
                namsx.Add(new ListItem( "200" + i,"200" + i));
                ddlNamSX.Items.Add(new ListItem(Convert.ToString(2000+i), Convert.ToString(2000 + i)));
            }
           
            //ddlNamSX.DataSource = namsx;
            //ddlNamSX.DataValueField ="value";
            //ddlNamSX.DataTextField = "text";                     
            //ddlNamSX.DataBind();
            
            ddlNamSX.Items.Insert(0, new ListItem("--Chọn--", "0"));
            ddlNamSX.SelectedIndex = 0;

        }
        protected void LoadHangXe()
        {
            //HangXeDTO hx = new HangXeDTO();
            //List<HangXeDTO> ls_hx = new List<HangXeDTO>();
            //ls_hx.Add(hx);
            //foreach (HangXeDTO hx_in in HangXeBUS.LayDS())
            //{
            //    ls_hx.Add(hx_in);
            //}

            ddlHangCheTao.DataSource = HangXeBUS.LayDS();      
            ddlHangCheTao.DataTextField = "TenHang";
            ddlHangCheTao.DataValueField = "Id";
            ddlHangCheTao.DataBind();
            
            ddlHangCheTao.Items.Insert(0, new ListItem("--Chọn--", "0"));
            ddlHangCheTao.SelectedIndex = 0;
        }
        protected void LoadDongXe()
        {
            List<string> ls_dongxe = new List<string> {"--Chọn--","SUV", "Sedan", "Coupe", "Truck", "Van", "Wagon", "Crossover" };
            ddlDongXe.DataSource = ls_dongxe;
            ddlDongXe.DataBind();
        }
        protected void btnDangTin_Click(object sender, EventArgs e)
        {

            //Gán giá trị cho DTO
            BangTinDTO bangtin = new BangTinDTO();

            bangtin.DoiXe = Convert.ToInt32(ddlLoaiXe.SelectedValue);
            bangtin.DongXe = ddlDongXe.SelectedItem.Value;
            bangtin.HangCheTao =Convert.ToInt32(ddlHangCheTao.SelectedValue);
            bangtin.TinhTrang = ddlTinhTrang.SelectedValue;            
            bangtin.NamSanXuat = Convert.ToInt32(ddlNamSX.SelectedItem.Value);
            bangtin.XuatXu = ddlXuatXu.SelectedItem.Value;
            bangtin.GiaTien = Convert.ToInt32(txtGiaTien.Text);
            bangtin.SoKm = Convert.ToInt32(txtSoKM.Text);

            string ss_nguoidang = Convert.ToString(Session["username"]);
           
            if (Session["username"] != null)
            {
                KhachHangDTO kh = BangTinBUS.LayThongTinNguoiDang(ss_nguoidang);
                bangtin.Id_nguoiDang = BangTinBUS.LayThongTinNguoiDang(ss_nguoidang).Id;
            }          
            else
                bangtin.Id_nguoiDang = 1;

            //Lấy dữ liệu từ người dùng và thêm vào tài khoản
            if (BangTinBUS.ThemTin(bangtin))
            {
                pnlThongBao.Visible = true;
                pnlThongBao.GroupingText = "Đăng tin thành công";
                pnlThongBao.CssClass = "alert alert-success";
                
            }
            else
            {
                pnlThongBao.Visible = true;
                pnlThongBao.CssClass = "alert alert-danger";
                pnlThongBao.GroupingText = "Đăng tin thất bại";
            }
        }

        protected void ddlHangCheTao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = ddlHangCheTao.SelectedValue;
        }
    }
}