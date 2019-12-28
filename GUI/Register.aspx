<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GUI.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Start Banner Area -->
    <section class="banner-area organic-breadcrumb">
        <div class="container">
            <div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
                <div class="col-first">
                    <h1>Đăng kí</h1>
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
                            <h4>Đăng nhập để sữ dụng được nhiều chức năng hơn</h4>
                            <p>Đăng nhập tài khoản tại đây</p>
                            <asp:HyperLink runat="server" CssClass="primary-btn" NavigateUrl="~/Login.aspx">Đăng nhập</asp:HyperLink>
                            <%--<a class="primary-btn" href="registration.html">Create an Account</a>--%>
                        </div>
                    </div>
                </div>

                <div class="col-lg-6">
                     <asp:Panel ID="pnlThongBao" CssClass="alert alert-success" runat="server" Visible="false"></asp:Panel>
                    <div class="login_form_inner">
                        <div class="section-title"><h3><b>Điền đầy đủ thông tin</b></h3></div>
                        <div class="row login_form" id="contactForm">
                            <div class="col-md-12 form-group">
                                <asp:TextBox CssClass="form-control" ID="txtName" runat="server" placeholder="Username" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Username'" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                                            ErrorMessage="Vui lòng nhập tên đăng nhập" Style="color:red"  
                                            ControlToValidate="txtName"> </asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:TextBox CssClass="form-control" ID="txtPass" TextMode="Password"  runat="server" name="pass" placeholder="Password" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Password'" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                                            ErrorMessage="Vui lòng nhập mật khẩu" Style="color:red"  
                                            ControlToValidate="txtPass"> </asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:TextBox CssClass="form-control" ID="txtRePass" TextMode="Password" runat="server" placeholder="Repassword" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Repassword'" />
                                  <ul>
                                      <li>
                                           <asp:CompareValidator ID="CompareValidator2" runat="server"
                                            ErrorMessage="Mật khẩu không trùng khớp"
                                            Style="color:red"                                           
                                            ControlToCompare="txtPass" ControlToValidate="txtRePass"> </asp:CompareValidator>
                                      </li>
                                      <li>
                                           <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"
                                            ErrorMessage="Vui lòng nhập xác nhận mật khẩu" Style="color:red"  
                                            ControlToValidate="txtRePass"> </asp:RequiredFieldValidator>
                                      </li>
                                  </ul>
                                
                               
                            </div>
                            <div class="col-md-12 form-group">
                                <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Email" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Username'" />
                                <ul>
                                    <li>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                            ErrorMessage="Vui lòng nhập email" Style="color: red"
                                            ControlToValidate="txtEmail"> </asp:RequiredFieldValidator>
                                    </li>
                                    <li>
                                        <asp:RegularExpressionValidator ID="string" runat="server"                                             
                                             ErrorMessage="Email không hợp lệ" Style="color: red"
                                             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                            ControlToValidate="txtEmail">  
                                        </asp:RegularExpressionValidator>
                                        
                                    </li>
                                </ul>
                            </div>
                            <!--Compare Validator-->
                            
                            <div class="col-md-12 form-group">
                                <!--Đăng kí-->
                                <asp:Button ID="btnRegister" CssClass="primary-btn" runat="server" Text="Đăng kí" OnClick="btnRegister_Click"></asp:Button>
                            </div>
                            <!--Validation-->
                      
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--================End Login Box Area =================-->
</asp:Content>
