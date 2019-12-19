using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace GUI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                rptDSSanPham.DataSource = SanPhamBUS.DSSanPham();
                rptDSSanPham.DataBind();
                
            }
        }
        protected void rptDSSanPham_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            //Giá tiền 
            string giatien_covernt;
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {

                int giaTien = Convert.ToInt32((item.FindControl("lblGiaSP") as Label).Text);
                if (giaTien > 999999999)
                {
                    giatien_covernt = String.Format("{0:f} Tỷ VNĐ", Convert.ToDouble(giaTien) / 1000000000);
                }
                else if (giaTien > 99999999 && giaTien < 999999999)
                {
                    giatien_covernt = String.Format("{0:n0} Triệu VNĐ", giaTien / 1000000);
                }
                else
                    giatien_covernt = String.Format("{0:n0} Triệu VNĐ", giaTien / 1000000);
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
                        (item.FindControl("lblHangXe") as Label).Text = String.Format("Hãng xe:{0} ", hangxe_convert);
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


        protected void lbtadtobag_Click(object sender, EventArgs e)
        {
        }
    }
}