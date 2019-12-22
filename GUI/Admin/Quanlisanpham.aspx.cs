using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BUS;

namespace GUI.Admin
{
    public partial class Dasboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDSsanpham();
            }
        }
        protected void LoadDSsanpham()
        {
            grvDanhsachsanpham.DataSource = BUS.SanPhamBUS.LayDSSanpham();
            grvDanhsachsanpham.DataBind();
        }

        protected void grvDanhsachsanpham_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="XoaSP")
            {
                int id = Convert.ToInt32(e.CommandArgument.ToString());
                if (SanPhamBUS.Xoasanpham(id))
                {
                    grvDanhsachsanpham.DataSource = BUS.SanPhamBUS.LayDSSanpham();
                    grvDanhsachsanpham.DataBind();
                }
            }
        }
        
    }
}