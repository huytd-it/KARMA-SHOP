<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="Shoppingcart.aspx.cs" Inherits="GUI.Shoppingcart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- Start Banner Area -->
    <section class="banner-area organic-breadcrumb">
        <div class="container">
            <div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
                <div class="col-first">
                    <h1>Shopping Cart</h1>
                    <nav class="d-flex align-items-center">
                        <a href="index.html">Home<span class="lnr lnr-arrow-right"></span></a>
                        <a href="category.html">Cart</a>
                    </nav>
                </div>
            </div>
        </div>
    </section>
    <!-- End Banner Area -->

    <!--================Cart Area =================-->
    <section class="cart_area">
        <div class="container">
            <div class="cart_inner">
                <div class="table-responsive">
                    <table class="table">
                        <thead>
                            <tr>
                                <th scope="col">Product</th>
                                <th scope="col">Price</th>
                                <th scope="col">Quantity</th>
                                <th scope="col">Total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <div class="media">
                                        <div class="d-flex">
                                            <asp:Image ID="anhminhhoa" runat="server" ImageUrl="~/img/product/p1.jpg" alt=""/>
                                        </div>
                                        <div class="media-body">
                                            <asp:Label ID="lblTenSP" runat="server">Giày Nice</asp:Label>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <asp:Label ID="lblGiaTien" runat="server">1000</asp:Label>
                                </td>
                                <td>
                       
                                    <div class="product_count">
                                        <asp:TextBox runat="server" name="qty" ID="txtSoLuong" maxlength="12" value="1" title="Quantity:"
                                            class="input-text qty"/>
                                        <button onclick="var result = document.getElementById('txtSoLuong'); var txtSoLuong = result.value; if( !isNaN( txtSoLuong )) result.value++;return false;"
                                            class="increase items-count" type="button"><i class="lnr lnr-chevron-up"></i></button>
                                        <button onclick="var result = document.getElementById('sst'); var sst = result.value; if( !isNaN( sst ) &amp;&amp; sst > 0 ) result.value--;return false;"
                                            class="reduced items-count" type="button"><i class="lnr lnr-chevron-down"></i></button>
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
        </div>
    </section>
    <!-
</asp:Content>
