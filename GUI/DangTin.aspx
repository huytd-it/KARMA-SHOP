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
                            <asp:HyperLink ID="reg" CssClass="primary-btn" NavigateUrl="~/Register.aspx" runat="server">Đăng kí tài khoản</asp:HyperLink>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="login_form_inner">
                        <div class="section-title">
                            <h3><b>Điền đầy đủ thông tin</b></h3>
                        </div>
                        <div class="row login_form" style="color:black">
                            <!--Hãng chế tạo-->
                            <asp:Label ID="Label2" runat="server" Text="Label">Hãng chế tạo</asp:Label><br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                 ErrorMessage="*Thông tin bắt buột phải chọn" ControlToValidate="ddlHangCheTao" InitialValue="0" 
                                 ForeColor="Red"></asp:RequiredFieldValidator>

                            <asp:DropDownList ID="ddlHangCheTao" CssClass="col-md-12 form-group"  runat="server" OnSelectedIndexChanged="ddlHangCheTao_SelectedIndexChanged">
                            </asp:DropDownList>
                            <!--Đời xe -->
                            <asp:Label ID="Label3" runat="server" Text="Label">Đời xe</asp:Label><br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" InitialValue="0"
                                 runat="server" ErrorMessage="*Thông tin bắt buột phải chọn" ControlToValidate="ddlLoaiXe" ForeColor="Red"></asp:RequiredFieldValidator>
                            
                            <asp:DropDownList ID="ddlLoaiXe" CssClass="col-md-12 form-group" runat="server">
                            </asp:DropDownList>
                            <!--Năm sản xuất -->
                            <asp:Label ID="Label4" runat="server" Text="Label">Năm sản xuất</asp:Label><br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                             ErrorMessage="*Thông tin bắt buột phải chọn" ControlToValidate="ddlNamSX" InitialValue="0"
                              ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:DropDownList ID="ddlNamSX" CssClass="col-md-12 form-group" runat="server">
                              
                            </asp:DropDownList>
                            <!--Xuất xứ -->

                            <asp:Label ID="Label5" runat="server" Text="Label">Xuất xứ</asp:Label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" InitialValue="0" ErrorMessage="*Thông tin bắt buột phải chọn" ControlToValidate="ddlXuatXu" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:DropDownList ID="ddlXuatXu" CssClass="col-md-12 form-group" runat="server">
                                <asp:ListItem Value="0" Selected="True">--Chọn--</asp:ListItem>
                                <asp:ListItem Value="Nhập khẩu"> Nhập khẩu </asp:ListItem>
                                <asp:ListItem Value="Lắp ráp trong nước">Lắp ráp trong nước</asp:ListItem>
                            </asp:DropDownList>
                            <!--Tình trạng-->
                            <asp:Label ID="Label6" runat="server" Text="Label">Tình trạng</asp:Label><br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" InitialValue="0" ErrorMessage="*Thông tin bắt buột phải chọn" ControlToValidate="ddlTinhTrang" ForeColor="Red"></asp:RequiredFieldValidator>

                            <asp:DropDownList ID="ddlTinhTrang"  CssClass="col-md-12 form-group" runat="server">
                                <asp:ListItem Value="0" Selected="True">--Chọn--</asp:ListItem>
                                <asp:ListItem Value="Used"> Xe đã dùng </asp:ListItem>
                                <asp:ListItem Value="New"> Xe mới </asp:ListItem>

                            </asp:DropDownList>
                              <!--Dòng xe-->
                            <asp:Label ID="Label1" runat="server" Text="Label">Dòng xe</asp:Label><br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server"  ErrorMessage="*Thông tin bắt buột phải chọn" ControlToValidate="ddlDongXe" InitialValue="--Chọn--" ForeColor="Red"></asp:RequiredFieldValidator>

                            <asp:DropDownList ID="ddlDongXe" CssClass="col-md-12 form-group" runat="server">
                            </asp:DropDownList>
                            <!--Số km đi được-->
                            <div class="form-group col-12">
                                <asp:Label ID="Label8" runat="server" Text="Số Km đi được"></asp:Label><br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="*Thông tin bắt buột phải nhập" ControlToValidate="txtSoKM" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:TextBox CssClass="form-control" ID="txtSoKM" placeholder="Nhập số km xe đi được" runat="server" />
                            </div>


                            <!--Giá tiền -->
                            <div class="form-group col-12">
                                <asp:Label ID="Label7" runat="server" Text="Giá tiền"></asp:Label><br />
                                <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator14" runat="server" ErrorMessage="*Thông tin bắt buột phải nhập" ControlToValidate="txtGiaTien"></asp:RequiredFieldValidator>
                                <asp:TextBox CssClass="form-control" ID="txtGiaTien" placeholder="Nhập giá tiền" runat="server" />
                            </div>
                            <!--Btn Đăng tin -->
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
