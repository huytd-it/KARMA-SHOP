<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="ProductSearch.aspx.cs" Inherits="GUI.ProductSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    	<!-- Start Banner Area -->
    <style>
        .sp-hover:hover{
            height:310px;
            width:220px;
        }
    </style>
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Trang sản phẩm</h1>
					<nav class="d-flex align-items-center">
						<asp:HyperLink Id="home" runat="server" NavigateUrl="~/Index.aspx">Trang chủ<span class="lnr lnr-arrow-right"></span></asp:HyperLink>						
                        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/ProductSearch.aspx" runat="server">Sản phẩm</asp:HyperLink>
					</nav>
				</div>
			</div>
		</div>
	</section>
	<!-- End Banner Area -->
	<div class="container">
		<div class="row">
            
			<div class="col-xl-3 col-lg-4 col-md-5">
                <div class="sidebar-filter mt-50">
					<div class="top-filter-head">Lọc sản phẩm</div>
                    <div class="common-filter">
                        <div class="head">Hãng xe</div>
                        <div class="row login_form price-range-area">
                            <asp:DropDownList ID="ddlHangXe" runat="server" CssClass="col-12 form-group" OnSelectedIndexChanged="ddlHangXe_SelectedIndexChanged" ></asp:DropDownList>
                        </div>
                    </div>
                    <div class="common-filter">
						<div class="head">Giá trị</div>
						<div class="price-range-area row login-form">                       
                            <asp:Label ID="Label3" runat="server" Text="Giá từ"></asp:Label>
                            <asp:DropDownList ID="ddlGiaTri" runat="server" CssClass="form-group col-12" OnSelectedIndexChanged="ddlGiaTri_SelectedIndexChanged">
                                <asp:ListItem Value="0">--Tất cả--</asp:ListItem>
                                <asp:ListItem Value="1">Trên 1 tỷ</asp:ListItem>
                                <asp:ListItem Value="2">Dưới 1 tỷ</asp:ListItem>
                                <asp:ListItem Value="3">Trên 800 triệu</asp:ListItem>
                                <asp:ListItem Value="4">Dưới 800 triệu</asp:ListItem>
                                <asp:ListItem Value="5">Trên 600 triệu</asp:ListItem>
                                <asp:ListItem Value="6">Dưới 600 triệu</asp:ListItem>
                                <asp:ListItem Value="7">Trên 400 triệu</asp:ListItem>
                                <asp:ListItem Value="8">Dưới 400 triệu</asp:ListItem>
                            </asp:DropDownList>
                            
                        </div>
					</div>
					<div class="common-filter">
						<div class="head">Năm sản xuất</div>
                        <div class="row login_form price-range-area">
                            <asp:Label ID="Label1" runat="server" Text="Từ năm"></asp:Label>
                            <asp:DropDownList ID="ddlNamSXLower" runat="server" CssClass="form-group col-12" OnSelectedIndexChanged="ddlNamSXLower_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:Label ID="Label2" runat="server" Text="Đến năm"></asp:Label>
                            <asp:DropDownList ID="ddlNamSXUpper" runat="server" CssClass="form-group col-12" OnSelectedIndexChanged="ddlNamSXUpper_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
					</div>
                 <div class="common-filter">
						<div class="head">Tình trạng</div>
                        <div class="row login_form price-range-area">                           
                            <asp:DropDownList ID="ddlTinhTrang" runat="server" Height="42px" Width="200px" OnSelectedIndexChanged="ddlTinhTrang_SelectedIndexChanged">
                                <asp:ListItem Value="0">--Tất cả--</asp:ListItem>
                                <asp:ListItem Value="True">Xe mới</asp:ListItem>
                                <asp:ListItem Value="False">Xe cũ</asp:ListItem>
                            </asp:DropDownList>
                        </div>
					</div>
				
                    <div class="common-filter">
						<div class="head">Hộp số</div>
                        <div class="row login_form price-range-area">                           
                            <asp:DropDownList ID="ddlHopSo" runat="server" Height="42px" Width="200px" OnSelectedIndexChanged="ddlHopSo_SelectedIndexChanged">
                                <asp:ListItem Value="0">--Tất cả--</asp:ListItem>
                                <asp:ListItem Value="Hộp số tay"></asp:ListItem>
                                <asp:ListItem Value="Hộp số tự động"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
					</div>
				
                    
					
				</div>
				<div class="sidebar-categories">
					<div class="head">Browse Categories</div>
					<ul class="main-categories">
						<li class="main-nav-list"><a data-toggle="collapse" href="#fruitsVegetable" aria-expanded="false" aria-controls="fruitsVegetable"><span
								 class="lnr lnr-arrow-right"></span>Fruits and Vegetables<span class="number">(53)</span></a>
							<ul class="collapse" id="fruitsVegetable" data-toggle="collapse" aria-expanded="false" aria-controls="fruitsVegetable">
								<li class="main-nav-list child"><a href="#">Frozen Fish<span class="number">(13)</span></a></li>
								<li class="main-nav-list child"><a href="#">Dried Fish<span class="number">(09)</span></a></li>
								<li class="main-nav-list child"><a href="#">Fresh Fish<span class="number">(17)</span></a></li>
								<li class="main-nav-list child"><a href="#">Meat Alternatives<span class="number">(01)</span></a></li>
								<li class="main-nav-list child"><a href="#">Meat<span class="number">(11)</span></a></li>
							</ul>
						</li>						
					</ul>
				</div>
				
			</div>
		<div class="col-xl-9 col-lg-8 col-md-7">
				<!-- Start Filter Bar -->
				<div class="filter-bar d-flex flex-wrap align-items-center">
					<div class="sorting">
                        
					</div>
					<div class="sorting mr-auto">
                       <!--DropDownList-->
					</div>
                    <div class="sorting mr-auto">
                       
					</div>
					<asp:Panel ID="pnlPhanTrang" runat="server">

					</asp:Panel>
				</div>
				<!-- End Filter Bar -->
				<!-- Start Best Seller -->
				<section class="lattest-product-area pb-40 category-list">
                      <h3>
                          <asp:Panel ID="pnlThongBao" runat="server" CssClass="alert alert-info"></asp:Panel>
                      </h3>
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
                                            <h4><asp:Label CssClass="card-text" ID="lblGiaSP" runat="server" Text='<%# Eval("giatien")%>'></asp:Label></h4>
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
                                            <asp:LinkButton ID="lbtadtobag" runat="server" CssClass="social-info" PostBackUrl='<%#Eval("id","Productdetail.aspx?id={0}")%>' CommandArgument='<%# Eval("id") %>'>
                                                <span class="lnr lnr-move"></span>
                                              
										        <p class="hover-text">Chi Tiết</p>
                                            </asp:LinkButton>
									        <a  class="social-info">
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
				</section>
				<!-- End Best Seller -->
				<!-- Start Filter Bar -->
				<div class="filter-bar d-flex flex-wrap align-items-center">
					<div class="sorting mr-auto">
						<select>
							<option value="1">Show 12</option>
							<option value="1">Show 12</option>
							<option value="1">Show 12</option>
						</select>
					</div>
					<div class="pagination">
						<a href="#" class="prev-arrow"><i class="fa fa-long-arrow-left" aria-hidden="true"></i></a>
						<a href="#" class="active">1</a>
						<a href="#">2</a>
						<a href="#">3</a>
						<a href="#" class="dot-dot"><i class="fa fa-ellipsis-h" aria-hidden="true"></i></a>
						<a href="#">6</a>
						<a href="#" class="next-arrow"><i class="fa fa-long-arrow-right" aria-hidden="true"></i></a>
					</div>
				</div>
				<!-- End Filter Bar -->
			</div>
		</div>
	</div>

	<!-- Start related-product Area -->
	<section class="related-product-area section_gap">
		<div class="container">
			<div class="row justify-content-center">
				<div class="col-lg-6 text-center">
					<div class="section-title">
						<h1>Deals of the Week</h1>
						<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore
							magna aliqua.</p>
					</div>
				</div>
			</div>
			<div class="row">
				<div class="col-lg-9">
					<div class="row">
						<div class="col-lg-4 col-md-4 col-sm-6 mb-20">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r1.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-6 mb-20">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r2.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-6 mb-20">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r3.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-6 mb-20">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r5.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-6 mb-20">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r6.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-6 mb-20">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r7.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-6">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r9.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-6">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r10.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-6">
							<div class="single-related-product d-flex">
								<a href="#"><img src="img/r11.jpg" alt=""></a>
								<div class="desc">
									<a href="#" class="title">Black lace Heels</a>
									<div class="price">
										<h6>$189.00</h6>
										<h6 class="l-through">$210.00</h6>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class="col-lg-3">
					<div class="ctg-right">
						<a href="#" target="_blank">
							<img class="img-fluid d-block mx-auto" src="img/category/c5.jpg" alt="">
						</a>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!-- End related-product Area -->

</asp:Content>
