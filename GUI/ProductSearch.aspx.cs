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
        protected string m_hangXe;
        protected string m_trangThai;
        protected int m_giatri;
        protected int m_namsx;
        protected string m_hopso;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadNamSX();
              
                rptDSSanPham.DataSource = SanPhamBUS.DSSanPham();
                rptDSSanPham.DataBind();

                ddlHangXe.AutoPostBack = true;
                ddlHopSo.AutoPostBack = true;
                ddlNamSXLower.AutoPostBack = true;
                ddlNamSXUpper.AutoPostBack = true;
                ddlTinhTrang.AutoPostBack = true;
                ddlGiaTri.AutoPostBack = true;
                ddlTinhTrang.AutoPostBack = true;


                //Load Hãng xe
                ddlHangXe.DataSource = HangXeBUS.LayDS();
                ddlHangXe.DataTextField = "TenHang";
                ddlHangXe.DataValueField = "Id";
                ddlHangXe.DataBind();
                ddlHangXe.Items.Insert(0, new ListItem("--Tất cả--", "0"));

                
            }
          
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
            if (e.Item.ItemType == ListItemType.AlternatingItem ||e.Item.ItemType == ListItemType.Item)
            {
                //Label giatien = e.Item.FindControl("lblGiaTien") as Label;
                // string TeklifId = giatien.Text;  //value here
                //HtmlGenericControl TeklifId = e.Item.FindControl("TeklifId") as HtmlGenericControl;
                //string TeklifId = TeklifId.InnerText;  //value here
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
            return SanPhamBUS.LocSP(sanpham);


        }
    }
}