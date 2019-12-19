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
    public partial class Productdetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetSP();

            int id = Convert.ToInt32(Request.QueryString["id"]);
            CTSanPhamDTO ct = CTSanPhamBUS.XemChiTiet(id);
            if (ct != null)
            {
                lbl_Khoiluong.Text = ct.Khoiluong;
                lbl_Congsuat.Text = ct.Congsuat;
                lbl_DaiRongCao.Text = ct.Dai_rong_cao;
                lbl_DK_Hanhtrinhpitong.Text = ct.D_hanhtrinhpittong;
                lbl_Dungtichnhot.Text = ct.Dungtichnhot;
                lbl_Dungtichxang.Text = ct.Dungtichxang;
                lbl_Kichcolopxe.Text = ct.Lopxe;
                lbl_Loaidongco.Text = ct.Loaidongco;
                lbl_Loaitruyendong.Text = ct.Loaitruyendong;
                lbl_Momencucdai.Text = ct.Momencucdai;
                lbl_Tysonen.Text = ct.Tysonen;
            }
            else
                Response.Write("<script>alert('Sản phẩm này chưa có chi tiết')</script>");
        }

        public void GetSP()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            SanPhamDTO sp = CTSanPhamBUS.LaySP(id);
            img_anh.ImageUrl = "~/img/product/" + sp.Anhminhhoa;
            lbl_ten.Text = sp.Tensanpham;
            lbl_gia.Text = sp.Giatien.ToString();
        }
    }
}