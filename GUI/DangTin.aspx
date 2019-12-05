<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="DangTin.aspx.cs" Inherits="GUI.DangTin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="banner-area organic-breadcrumb">
        <div class="container">
            <div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
                <div class="col-first">
                    <h1>Login</h1>
                    <nav class="d-flex align-items-center">
                        <asp:HyperLink ID="hplHome" runat="server" NavigateUrl="~/Index.aspx">Home<span class="lnr lnr-arrow-right"></span></asp:HyperLink>
                        <asp:HyperLink ID="hblRegister" runat="server" Text="Register" NavigateUrl="~/Register.aspx"></asp:HyperLink>
                    </nav>
                </div>
            </div>
        </div>
    </section>
    <section class="login_box_area section_gap">
       
        <div class="container">
             
            <div class="row">
                
                <div class="col-lg-6">
                    <asp:Panel ID="pnlThongBao" CssClass="alert alert-success" runat="server" Visible="false"></asp:Panel>
                    <div class="login_box_img">
                        <img class="img-fluid" src="img/login.jpg" alt="">
                        <div class="hover">
                            <h4>Bạn chưa có tài khoản?</h4>
                            <p>Tạo một tài khoản ở đây để đăng tin</p>
                            <a class="primary-btn" href="registration.html">Đăng kí tài khoản</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="login_form_inner">
                        <h3>Thông tin xe cần bán</h3>
                        <div class="row login_form">

                            <asp:Label ID="Label2" runat="server" Text="Label">Hãng chế tạo</asp:Label>
                            <asp:DropDownList ID="ddlHangCheTao" CssClass="col-md-12 form-group" runat="server">                               
                            </asp:DropDownList>

                            <asp:Label ID="Label3" runat="server" Text="Label">Đời xe</asp:Label>
                            <asp:DropDownList ID="ddlLoaiXe" CssClass="col-md-12 form-group" runat="server">                               
                            </asp:DropDownList>

                            <asp:Label ID="Label4" runat="server" Text="Label" >Năm sản xuất</asp:Label>
                            <asp:DropDownList ID="ddlNamSX" CssClass="col-md-12 form-group" runat="server">
                                <asp:ListItem Selected="True" Value=" "></asp:ListItem>                                                                           
                            </asp:DropDownList>
                           

                            <asp:Label ID="Label5" runat="server" Text="Label">Xuất xứ</asp:Label>
                            <asp:DropDownList ID="ddlXuatXu" CssClass="col-md-12 form-group" runat="server">
                                <asp:ListItem Selected="True">Chọn</asp:ListItem>
                                <asp:ListItem Value="Nhập khẩu"> Nhập khẩu </asp:ListItem>
                                <asp:ListItem Value="Lắp ráp trong nước">Lắp ráp trong nước</asp:ListItem>
                            </asp:DropDownList>


                            <asp:Label ID="Label6" runat="server" Text="Label">Tình trạng</asp:Label>

                            <asp:DropDownList  ID="ddlTinhTrang" CssClass="col-md-12 form-group" runat="server">
                                <asp:ListItem Selected="True" ></asp:ListItem>
                                <asp:ListItem Value="Used"> Xe đã dùng </asp:ListItem>
                                <asp:ListItem Value="New"> Xe mới </asp:ListItem>

                            </asp:DropDownList>

                             <div class="col-md-12 form-group">
                                <asp:Label ID="Label8" runat="server" Text="Số Km đi được"></asp:Label>
                                <asp:TextBox CssClass="form-control" ID="txtSoKM" runat="server" />
                            </div>
                             <asp:Label ID="Label1" runat="server" Text="Label">Dòng xe</asp:Label>
                            <asp:DropDownList ID="ddlDongXe" CssClass="col-md-12 form-group" runat="server">                                                    
                            </asp:DropDownList>

                            <div class="col-md-12 form-group">
                                <asp:Label ID="Label7" runat="server" Text="Giá tiền"></asp:Label>
                                <asp:TextBox CssClass="form-control" ID="txtGiaTien" runat="server" />
                            </div>
                           

                            <div class="col-md-12 form-group">
                                <asp:Button ID="btnDangTin" CssClass="primary-btn" runat="server" Text="Đăng tin" OnClick="btnDangTin_Click"></asp:Button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
