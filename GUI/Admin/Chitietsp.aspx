<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Publicpage.Master" AutoEventWireup="true" CodeBehind="Chitietsp.aspx.cs" Inherits="GUI.Admin.Chitietsp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="content">
        <div id="content-header">
            <div id="breadcrumb"> <asp:Hyperlink runat="server" href="#" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i> Home</asp:Hyperlink> <asp:Hyperlink runat="server" href="#" class="current">Tables</asp:Hyperlink> </div>
            <h1>Tables</h1>
          </div>
        <div class="container-fluid">
        <hr/>
        <div class="row-fluid">
        <div class="span12">
           <div class="widget-box">
        <div class="widget-title"> <span class="icon"> <i class="icon-align-justify"></i> </span>
          <h5>thong tin san pham </h5>
        </div>
        <div class="widget-content nopadding">
                 <asp:Panel ID="pnlThongBao" CssClass="alert alert-success" runat="server" Visible="false"></asp:Panel>
          <div class="form-horizontal">
            <div class="control-group">
              <label class="control-label">Tên Sản Phẩm :</label>
              <div class="controls">
                <asp:TextBox runat="server" ID="txtTensp" type="text" class="span11" placeholder="Tên Sản Phẩm"></asp:TextBox></div>
                    <div class="controls"> 
                   
                     <ul class="thumbnail"> 
                      <li class="span2"> <asp:Hyperlink runat="server"> <asp:Image ID="imgAnh" runat="server"  alt=""/> </asp:Hyperlink>
                         <div class="actions"> <asp:Hyperlink ID="hplanhct" runat="server" class="lightbox_trigger"><i class="icon-search"></i></asp:Hyperlink> </div>
                         </li>
                     </ul>
                   
                    </div>
                 </div>
                 <div class="form-horizontal">
                <label class="control-label">File upload input</label>
              <div class="controls">
                <div class="uploader" id="uniform-undefined"><asp:FileUpload ID="fulanh" runat="server" BorderWidth="3px" /><asp:label runat="server" class="action">Choose File</asp:label></div>
                <asp:Button CssClass="btn btn-success btn" runat="server" OnClick="Upload" Text="Upload" />
                   </div>

            </div>
                   <label class="control-label">Gia Tien :</label>
              <div class="controls">
                <asp:TextBox runat="server" ID="txtGiatien" type="text" class="span11" placeholder="Giá tiền"></asp:TextBox>
                 </div> <label class="control-label">Số lượng :</label>
              <div class="controls">
                <asp:TextBox runat="server" ID="txtsoluong" type="text" class="span11" placeholder="Số lượng"></asp:TextBox>
                </div>
                <label class="control-label">Ghi chú :</label>
              <div class="controls">
                <asp:TextBox runat="server" ID="txtghichu" type="text" class="span11" placeholder="Ghi chú"></asp:TextBox>
                </div>
              </div>
                  </div>
               <asp:Button CssClass="btn btn-success btn-large" ID="btnsua"  runat="server"  OnClick="UpDate" Text="Cap Nhat" />
        </div>
        </div>
        </div>
        </div>
     </div>
</asp:Content>
