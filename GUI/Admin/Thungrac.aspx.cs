using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace GUI.Admin
{
    public partial class Thungrac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LayDSsanpham();
            }

        }
        protected void LayDSsanpham()
        {
           grvThungrac.DataSource= BUS.SanPhamBUS.LayDSSanphamxoa();
           grvThungrac.DataBind();
        }

        protected void grvThungrac_RowCommand(object sender,GridViewCommandEventArgs e)
        {
            if(e.CommandName=="KhoiphucSP")
            {
                int id = Convert.ToInt32(e.CommandArgument.ToString());
                if(SanPhamBUS.Khoiphucsanpham(id))
                {
                    grvThungrac.DataSource = BUS.SanPhamBUS.LayDSSanphamxoa();
                    grvThungrac.DataBind();
                }
            }
        }
    }
}