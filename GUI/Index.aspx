<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="GUI.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- start banner Area -->
	<section class="banner-area">
		<div class="container">
			<div class="row fullscreen align-items-center justify-content-start">
				<div class="col-lg-12">
					<div class="active-banner-slider owl-carousel">
						<!-- single-slide -->
						<div class="row single-slide align-items-center d-flex">
							<div class="col-lg-5 col-md-6">
								<div class="banner-content">
									<h1>Monkey <br/>Collection!</h1>
									<p>Thiết kế mới lạ Chất cho dân chơi</p>
									<div class="add-bag d-flex align-items-center">
										<asp:LinkButton ID="btnAdd" runat="server" PostBackUrl="~/Productdetail.aspx" CssClass="add-btn" ><span class="lnr lnr-cross"></span></asp:LinkButton>
										
    <span class="add-text text-uppercase">Add to Bag</span>
									</div>
								</div>
							</div>
							<div class="col-lg-7">
								<div class="banner-img">
									<asp:HyperLink CssClass="img-fluid" NavigateUrl="~/Productdetail.aspx" ImageUrl="~/img/product/monkey.png" runat="server" ></asp:HyperLink>
								</div>
							</div>
						</div>
						<!-- single-slide -->       
						<div class="row single-slide">
							<div class="col-lg-5">
								<div class="banner-content">
									<h1>Nike New <br />Collection!</h1>
									<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et
										dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.</p>
									<div class="add-bag d-flex align-items-center">
										<a class="add-btn"><span class="lnr lnr-cross"></span></a>
										<span class="add-text text-uppercase">Thêm vào giỏ</span>
									</div>
								</div>
							</div>
							<div class="col-lg-7">
								<div class="banner-img">
									<asp:Image ID="imgAvatar" CssClass="img-fluid" ImageUrl="~/img/product/monkey.png" runat="server" />
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!-- End banner Area -->
	<!-- start product Area -->		
		<!-- single product slide -->

    <div class="single-product-slider">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-lg-6 text-center">
                    <div class="section-title">
                        <h1><b>XE CÓ TRONG CỬA HÀNG</b></h1>
                        <p>"CỬA HÀNG XE KARMA HÂN HẠNH PHỤC VỤ QUÝ KHÁCH HÀNG"</p>
                    </div>
                </div>
            </div>
            <!--Repeater-->
            <div class="row">
                <asp:Repeater ID="rptDSSanPham" runat="server" OnItemDataBound="rptDSSanPham_ItemDataBound">
                    <ItemTemplate>
                        <div class="col-lg-3 col-md-3">
                            <asp:Panel ID="pnlSanPhamSingle" runat="server" Height="355" Width="210" CssClass="single-product card ">
                                <asp:Image CssClass="img-fluid card-img-top" Width="180" Height="110" ImageUrl='<%#"/img/product/" + Eval("anhminhhoa") %>' runat="server" />
                                <div class="product-details card-body">
                                    <asp:Label CssClass="card-text" ID="lblTenSP" runat="server" Text='<%#Eval("tensanpham")%>'></asp:Label>
                                    <hr />
                                    <div class="price">
                                        <h4>
                                            <asp:Label CssClass="card-text" ID="lblGiaSP" runat="server" Text='<%# Eval("giatien")%>'></asp:Label></h4>
                                    </div>
                                    <div class="price">
                                        <asp:Label CssClass="card-text" ID="lblHangXe" runat="server" Text='<%# Eval("hangxe")%>'></asp:Label>
                                    </div>
                                    <div class="price">
                                        <asp:Label CssClass="card-text" ID="Label4" runat="server" Text='<%# Eval("ghichu")%>'></asp:Label>
                                    </div>
                                    <div class="price">
                                        <asp:Label CssClass="card-text" ID="lblTrangThai" runat="server" Text='<%# Eval("trangthai")%>'></asp:Label>
                                    </div>
                                    <hr />
                                    <div class="prd-bottom">
                                        <asp:LinkButton ID="lbtadtobag" runat="server" CssClass="social-info" PostBackUrl='<%# Eval("id","~/Productdetail.aspx?id={0}") %>' CommandArgument='<%# Eval("id") %>'>
                                                <span class="lnr lnr-move"></span>
                                              
										        <p class="hover-text">Chi Tiết</p>
                                        </asp:LinkButton>
                                        <a class="social-info">
                                            <span class="lnr lnr-heart"></span>
                                            <p class="hover-text">Yêu Thích</p>
                                        </a>
                                    </div>
                                </div>
                            </asp:Panel>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>

    </div>
</asp:Content>