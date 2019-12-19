using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class ProductSearch : System.Web.UI.Page
    {
        protected List<SanPhamDTO> current_product = new List<SanPhamDTO>();    
        protected int lenght;//sản phẩm tìm được
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadNamSX();
                pnlThongBao.GroupingText = "Các sản phẩm được tìm thấy";

                AutoPostBack();


                //Load Hãng xe
                LoadHangXe();

                phanTrang();

            }


        }

        private void AutoPostBack()
        {
            ddlHangXe.AutoPostBack = true;
            ddlHopSo.AutoPostBack = true;
            ddlNamSXLower.AutoPostBack = true;
            ddlNamSXUpper.AutoPostBack = true;
            ddlTinhTrang.AutoPostBack = true;
            ddlGiaTri.AutoPostBack = true;
            ddlTinhTrang.AutoPostBack = true;
        }

        private void LoadHangXe()
        {
            ddlHangXe.DataSource = HangXeBUS.LayDS();
            ddlHangXe.DataTextField = "TenHang";
            ddlHangXe.DataValueField = "Id";
            ddlHangXe.DataBind();
            ddlHangXe.Items.Insert(0, new ListItem("--Tất cả--", "0"));
        }

        protected void phanTrang()
        {
            PhanTrangBUS phantrang = new PhanTrangBUS();

            if (String.IsNullOrEmpty(Request.QueryString["page"]) == false)
            {
                phantrang.current_page = Convert.ToInt32(Request.QueryString["page"]);
            }
            phantrang.total_record = SanPhamBUS.DSSanPham().Count();
            phantrang.limit = 8;
            phantrang.link_full = "ProductSearch.aspx?page={page}";
            phantrang.link_first = "ProductSearch.aspx";
            phantrang.range = 6;

            phantrang.init();
            pnlPhanTrang.GroupingText = phantrang.showHtml();

            rptDSSanPham.DataSource = SanPhamBUS.DSSanPham(phantrang.limit, phantrang.start);
            rptDSSanPham.DataBind();

        }


        protected void LoadNamSX()
        {
            List<ListItem> namsx = new List<ListItem>();

            for (int i = 19; i > 0; i--)
            {
                namsx.Add(new ListItem(Convert.ToString(2000 + i), Convert.ToString(2000 + i)));               
            }
            

            ddlNamSXLower.DataSource = namsx;
            ddlNamSXUpper.DataSource = namsx;
            ddlNamSXLower.DataValueField ="value";
            ddlNamSXLower.DataTextField = "text";                     
            ddlNamSXLower.DataBind();
            ddlNamSXUpper.DataBind();

            ddlNamSXLower.Items.Insert(0, new ListItem("--Tất cả--", "0"));
            ddlNamSXUpper.Items.Insert(0, new ListItem("--Tất cả--", "0"));
            ddlNamSXUpper.SelectedIndex = 0;
            ddlNamSXUpper.SelectedIndex = 0;

        }


        protected void rptDSSanPham_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            //Giá tiền 
            string giatien_covernt;
            if (e.Item.ItemType == ListItemType.AlternatingItem ||e.Item.ItemType == ListItemType.Item)
            {
                
                int giaTien = Convert.ToInt32((item.FindControl("lblGiaSP")as Label).Text);
                if(giaTien > 999999999)
                {
                    giatien_covernt = String.Format("{0:f} Tỷ VNĐ", Convert.ToDouble(giaTien) / 1000000000);
                }
                else if( giaTien > 99999999 && giaTien < 999999999)
                {
                    giatien_covernt = String.Format("{0:n0} Triệu VNĐ", giaTien / 1000000);
                }
                else
                    giatien_covernt = String.Format("{0:n0} Triệu VNĐ",giaTien/1000000);
                (e.Item.FindControl("lblGiaSP") as Label).Text = giatien_covernt;            
            }
            //Tên hãng xe
            string hangxe_convert;
            List<HangXeDTO> ls_hangxe = HangXeBUS.LayDS();
            for (int i = 0; i < ls_hangxe.Count(); i++)
            {
                if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
                {                 
                    int hangXe = Convert.ToInt32((item.FindControl("lblHangXe") as Label).Text);
                    if (hangXe == ls_hangxe[i].Id)
                    {
                        hangxe_convert = ls_hangxe[i].TenHang;
                        (item.FindControl("lblHangXe") as Label).Text =String.Format("Hãng xe:{0} ",hangxe_convert);
                        break;
                    }
                       
                }
            }
            //Tên hộp số
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                string hopso_convert;
                bool hopso = Convert.ToBoolean((item.FindControl("lblTrangThai") as Label).Text);
                if (hopso == true)
                    hopso_convert = "Xe mới";
                else
                    hopso_convert = "Xe cũ";
                (e.Item.FindControl("lblTrangThai") as Label).Text = hopso_convert;
            }


        }

        protected void ddlHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {

            rptDSSanPham.DataSource = filter();
            rptDSSanPham.DataBind(); 
            
        }

        protected void ddlTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            rptDSSanPham.DataSource = filter();
            rptDSSanPham.DataBind();
        }

        protected void ddlHopSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rptDSSanPham.DataSource = filter();
            rptDSSanPham.DataBind();
        }
       

        protected void ddlNamSXLower_SelectedIndexChanged(object sender, EventArgs e)
        {
            rptDSSanPham.DataSource = filter();
            rptDSSanPham.DataBind();
        }

        protected void ddlNamSXUpper_SelectedIndexChanged(object sender, EventArgs e)
        {
            rptDSSanPham.DataSource = filter();
            rptDSSanPham.DataBind();
        }

        protected void ddlGiaTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            rptDSSanPham.DataSource = filter();
            rptDSSanPham.DataBind();
        }
        protected List<SanPhamDTO> filter()
        {

            var sanpham = new Dictionary<string, string>()
            {

                {"tenHang",ddlHangXe.SelectedValue  },
                {"tinhTrang",ddlTinhTrang.SelectedValue  },
                {"giaTri",ddlGiaTri.SelectedValue  },
                {"namSXLower",ddlNamSXLower.SelectedValue  },
                {"namSXUpper",ddlNamSXUpper.SelectedValue  },               
                {"hopSo",ddlHopSo.SelectedValue  },


            };
            lenght = SanPhamBUS.LocSP(sanpham).Count();
            if(lenght > 0)
                pnlThongBao.GroupingText = "Có " + lenght + " sản phẩm được tìm thấy";
            else
                pnlThongBao.GroupingText = "Không có  sản phẩm được tìm thấy";
            return SanPhamBUS.LocSP(sanpham);


        }
    }
}