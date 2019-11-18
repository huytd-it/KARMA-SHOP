<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GUI.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
    <section class="banner-area organic-breadcrumb">
        <div class="container">
            <div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
                <div class="col-first">
                    <h1>Register</h1>
                    <nav class="d-flex align-items-center">
                        <asp:HyperLink ID="hplHome" runat="server" NavigateUrl="~/Index.aspx">Home<span class="lnr lnr-arrow-right"></span></asp:HyperLink>
                        <asp:HyperLink ID="hblRegister" runat="server" Text="Login" NavigateUrl="~/Register.aspx"></asp:HyperLink>
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
                            <h4>New to our website?</h4>
                            <p>There are advances being made in science and technology everyday, and a good example of this is the</p>
                            <asp:LinkButton runat="server" CssClass="primary-btn" PostBackUrl="~/Login.aspx">Login</asp:LinkButton>
                            <%--<a class="primary-btn" href="registration.html">Create an Account</a>--%>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="login_form_inner">
                        <h3>Điền đầy đủ thông tin</h3>
                        <div class="row login_form" id="contactForm">
                            <div class="col-md-12 form-group">
                                <asp:TextBox CssClass="form-control" ID="txtName" runat="server" placeholder="Username" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Username'" />
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:TextBox CssClass="form-control" ID="txtPass" runat="server" name="pass" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'" />
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:TextBox CssClass="form-control" ID="txtRePass" runat="server" placeholder="Repassword" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Repassword'" />
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Email" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Username'" />
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:Button ID="btnRegister" CssClass="primary-btn" runat="server" Text="Đăng kí" OnClick="btnRegister_Click"></asp:Button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================End Login Box Area =================-->
</asp:Content>
