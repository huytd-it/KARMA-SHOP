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
    public partial class ProductLike : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["username"] != null)
            {
                string session = Session["username"].ToString();
                if(!Page.IsPostBack)
                {
                    rptDSYeuthich.DataSource = YeuThichBUS.DsSanphamYT(session);
                    rptDSYeuthich.DataBind();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void rptDSYeuthich_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "btn_Huy")
            {
                YeuThichDTO YT = new YeuThichDTO();
                YT.Tendangnhap1 = Session["username"].ToString();
                YT.MaXe1 = Convert.ToInt32(e.CommandArgument.ToString());
                if (YeuThichBUS.Xoa(YT))
                {
                    Response.Redirect("ProductLike.aspx");
                }
            }
        }


    }
}