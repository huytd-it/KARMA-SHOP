<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="QuanLyTaiKhoan.aspx.cs" Inherits="GUI.QuanLyTaiKhoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Login</h1>
					<nav class="d-flex align-items-center">
						<asp:HyperLink ID="hplHome" runat="server" NavigateUrl="~/Index.aspx" >Home<span class="lnr lnr-arrow-right"></span></asp:HyperLink>
						<asp:HyperLink ID="hblRegister" runat="server" Text="Register" NavigateUrl="~/Register.aspx"></asp:HyperLink>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->
<!--================Login Box Area =================-->
	<section class="login_box_area section_gap">
		<div class="container">
			<div class="row">
				<div class="col-lg-6">
					<div class="login_box_img">
						<img class="img-fluid" src="img/login.jpg" alt="">
						<div class="hover">
							<h4>Bạn có tài khoản chưa?</h4>
							<p>Tạo một tài khoản nếu bạn chưa có tại đây</p>
                            <asp:HyperLink runat="server" CssClass ="primary-btn" NavigateUrl="~/Register.aspx">Đăng kí tài khoản</asp:HyperLink>
                            <%--<a class="primary-btn" href="registration.html">Create an Account</a>--%>
						</div>
					</div>
				</div>
				<div class="col-lg-6">
                    <asp:Panel ID="pnlThongBao" CssClass="alert alert-success" runat="server" Visible="false"></asp:Panel>
					<div class="login_form_inner">
						<div class="section-title"><h3><b>Điền đầy đủ thông tin</b></h3></div>
						<div class="row login_form"  id="contactForm">
					
                            <div class="col-md-12 form-group">
                               <asp:Label ID="Label6" runat="server" Text="Tên tài khoản"></asp:Label>                                                        
                              <asp:TextBox cssClass="form-control" ID="txtTenTaiKhoan" runat="server" name="pass"  />
                            </div>
                            <div class="col-md-12 form-group">     
                                <asp:Label ID="Label2" runat="server" Text="Mật khẩu cũ"></asp:Label>                                                   
                              <asp:TextBox cssClass="form-control" ID="txtMatKhauCu" runat="server" name="pass" TextMode="Password"  />
							      <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                                    Style="color:red" ControlToValidate="txtMatKhauCu"
                                     runat="server" ErrorMessage="Vui lòng nhập mật khẩu"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 form-group">     
                                <asp:Label ID="Label7" runat="server" Text="Mật khẩu mới"></asp:Label>                                                   
                              <asp:TextBox cssClass="form-control" ID="txtMatKhauMoi" runat="server" name="pass" TextMode="Password"  />
							      <asp:RequiredFieldValidator ID="RequiredFieldValidator7"
                                    Style="color:red" ControlToValidate="txtMatKhauMoi"
                                     runat="server" ErrorMessage="Vui lòng nhập mật khẩu"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 form-group">    
                                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>                                                    
                              <asp:TextBox cssClass="form-control" ID="txtEmail" runat="server" name="pass" TextMode="Email"/>
							      <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                    Style="color:red" ControlToValidate="txtEmail"
                                     runat="server" ErrorMessage="Vui lòng nhập email"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:Label ID="Label4" runat="server" Text="Số điện thoại"></asp:Label>                                                        
                              <asp:TextBox cssClass="form-control" ID="txtDienThoai" runat="server" name="pass" />
							      <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                                    Style="color:red" ControlToValidate="txtDienThoai"
                                     runat="server" ErrorMessage="Vui lòng nhập số thoại"></asp:RequiredFieldValidator>
                            </div>
                             <div class="col-md-12 form-group">
                                <asp:Label ID="Label8" runat="server" Text="Địa chỉ"></asp:Label>                                                        
                              <asp:TextBox cssClass="form-control" ID="txtDiaChi" runat="server" name="pass" />
							      <asp:RequiredFieldValidator ID="RequiredFieldValidator8"
                                    Style="color:red" ControlToValidate="txtDiaChi"
                                     runat="server" ErrorMessage="Vui lòng nhập địa chỉ"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:Label ID="Label1" runat="server" Text="Ngày sinh"></asp:Label>                                                        
                              <asp:TextBox CssClass="form-control" ID="txtNgaysinh" runat="server" TextMode="Date" name="date" />
							      <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                                    Style="color:red" ControlToValidate="txtNgaysinh"
                                     runat="server" ErrorMessage="Vui lòng nhập ngày sinh"></asp:RequiredFieldValidator>
                            </div>
							<div class="col-md-12">
                                <asp:Label ID="Label5" CssClass="form-text" runat="server" Text="Giới tính"></asp:Label>
								<asp:DropDownList ID="ddlTinhTrang"  CssClass="col-md-12 form-select" runat="server">
                                <asp:ListItem Value="0" Selected="True">--Chọn--</asp:ListItem>
                                <asp:ListItem Value="Used"> Nam </asp:ListItem>
                                <asp:ListItem Value="New"> Nữ </asp:ListItem>
                                 </asp:DropDownList>
							</div>
							<div class="col-md-12 form-group">
								<asp:Button ID="btnLogin" CssClass="primary-btn" runat="server" Text="Login"></asp:Button>
								<a href="#">Forgot Password?</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--================End Login Box Area =================-->
    </asp:Content>
