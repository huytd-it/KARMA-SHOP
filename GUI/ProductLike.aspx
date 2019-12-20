<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="ProductLike.aspx.cs" Inherits="GUI.ProductLike" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <section class="banner-area organic-breadcrumb">
        <div class="container">
            <div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
                <div class="col-first">
                    <h1>Yêu Thích</h1>
                </div>
            </div>
        </div>
    </section>
    <section class="cart_area">
        <div class="container">
            <asp:Repeater ID="rptDSYeuthich" runat="server" OnItemCommand="rptDSYeuthich_ItemCommand">
                <ItemTemplate>
                    <div class="row">
                        <div class="col-lg-3  col-md-6 col-sm-6">
                            <asp:Image ID="img_anh" runat="server" Width="180" Height="110" ImageUrl='<%#"/img/product/" + Eval("anhminhhoa") %>' />
                        </div>
                        <div class="col-lg-4  col-md-6 col-sm-6">
                            <h4><asp:Label ID="lbl_Tenxe" runat="server" Text='<%#Eval("tensanpham")%>' ></asp:Label></h4>
                        </div>
                        <div class="col-lg-3  col-md-6 col-sm-6">
                            <h4><asp:Label ID="lbl_Giatien" runat="server" Text='<%# Eval("giatien")%>'></asp:Label></h4>
                        </div>
                        <div class="col-lg-2  col-md-6 col-sm-6">
                            <asp:Button ID="btn_Huy" runat="server" Width="100" Height="30" Text="Hủy" CommandName="btn_Huy" CssClass="" CommandArgument='<%#Eval("id") %>'></asp:Button>
                        </div>
                    </div>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
           <%-- <!--HIHIHI-->
           <div class="cart_inner">
                <div class="table-responsive">
                    <table class="table">
                        <tbody>
                            <tr>
                                <td>
                                    <div class="media">
                                        <div class="d-flex">
                                            <img src="img/cart.jpg" alt="">
                                        </div>
                                        <div class="media-body">
                                            <p>Minimalistic shop for multipurpose use</p>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <h5>$720.00</h5>
                                </td>
                            </tr>  
                        </tbody>
                    </table>
                </div>
            </div>
            <!--HIHIHI-->--%>
        </div>
    </section>
</asp:Content>
