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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

   

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();

            tk.TenDangNhap = txtName.Text;
            tk.MatKhau = txtPass.Text;
            tk.Email = txtEmail.Text;
            string KTMatKhau = txtRePass.Text;
          
            if (TaiKhoanBUS.DangKi(tk))
            {
                pnlThongBao.Visible = true;
                pnlThongBao.GroupingText = "Đăng kí thành công";
                pnlThongBao.CssClass = "alert alert-success";
            }
            else
            {
                pnlThongBao.Visible = true;
                pnlThongBao.GroupingText = "Tên đăng nhập đã tồn tại";
                pnlThongBao.CssClass = "alert alert-danger";
            }
            
           
                
        }
    }
}