using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace GUI.Admin
{
    public partial class Dasboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDSsanpham();
        }
        protected void LoadDSsanpham()
        {
            grvDanhsachsanpham.DataSource = BUS.SanPhamBUS.LayDSSanpham();
            grvDanhsachsanpham.DataBind();
        }
    }
}