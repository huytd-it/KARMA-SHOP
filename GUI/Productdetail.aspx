<%@ Page Title="" Language="C#" MasterPageFile="~/PublicPage.Master" AutoEventWireup="true" CodeBehind="Productdetail.aspx.cs" Inherits="GUI.Productdetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Start Banner Area -->
	<section class="banner-area organic-breadcrumb">
		<div class="container">
			<div class="breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end">
				<div class="col-first">
					<h1>Product Details</h1>
				</div>
			</div>
		</div>
	</section>

    <!-- Start Product Detail-->
    	<!--================Single Product Area =================-->
	<div class="product_image_area">
		<div class="container">
			<div class="row s_product_inner">
				<div class="col-lg-5">
						<div class="single-prd-item">
                            <asp:Image runat="server" CssClass ="img-fluid" ImageUrl="~/img/product/monkey.png"/>
						</div>
				</div>
				<div class="col-lg-6 offset-lg-1">
					<div class="s_product_text">
                        <h3><asp:Label ID="lbl_ten" runat="server" Text="Faded SkyBlu"></asp:Label></h3>
						<h2><asp:Label ID="lbl_gia" runat="server" Text="$149.99"></asp:Label></h2>
						<ul class="list">
							<li><a class="active" href="#"><span>Category:</span>  Household</a></li>
							<li><a href="#"> <span>Availibility:In Stock </span> </a></li>
						</ul>
						<asp:Label ID="lbl_ghichu" runat="server" Text="Ghi Chú Bảng Xe"></asp:Label>
						<div class="card_area d-flex align-items-center">
                            <asp:LinkButton ID="lbt_yeuthich" runat="server" CssClass="primary-btn" Text="Yêu Thích"></asp:LinkButton>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
    <!-- End Single Producy -->
    <!--================Product Description Area =================-->
	<section class="product_description_area">
		<div class="container">
			<ul class="nav nav-tabs" id="myTab" role="tablist">
				<li class="nav-item">
					<a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile"
					 aria-selected="false">Thông Số Kỹ Thuật</a>
				</li>
			</ul>
			<div class="tab-content" id="myTabContent">
				<div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
					<div class="table-responsive">
						<table class="table">
							<tbody>
								<tr>
									<td>
										<h5>Khối Lượng</h5>
									</td>
									<td>
										<h5><asp:Label ID="lbl_Khoiluong" runat="server" Text=""></asp:Label></h5>
									</td>
								</tr>
								<tr>
									<td>
										<h5>Dài_Rộng_Cao</h5>
									</td>
									<td>
										<h5><asp:Label ID="lbl_DaiRongCao" runat="server"></asp:Label></h5>
									</td>
								</tr>
								<tr>
									<td>
										<h5>Dung Tích Xăng</h5>
									</td>
									<td>
										<h5><asp:Label ID="lbl_Dungtichxang" runat="server"></asp:Label></h5>
									</td>
								</tr>
								<tr>
									<td>
										<h5>Kích Cỡ Lốp Xe</h5>
									</td>
									<td>
										<h5><asp:Label ID="lbl_Kichcolopxe" runat="server"></asp:Label></h5>
									</td>
								</tr>
								<tr>
									<td>
										<h5>Loại Động Cơ</h5>
									</td>
									<td>
										<h5><asp:Label ID="lbl_Loaidongco" runat="server"></asp:Label></h5>
									</td>
								</tr>
								<tr>
									<td>
										<h5>Đường Kính_Hành Trình Pitong</h5>
									</td>
									<td>
										<h5><asp:Label ID="lbl_DK_Hanhtrinhpitong" runat="server"></asp:Label></h5>
									</td>
								</tr>
								<tr>
									<td>
										<h5>Tỷ Số Nén</h5>
									</td>
									<td>
										<h5><asp:Label ID="lbl_Tysonen" runat="server"></asp:Label></h5>
									</td>
								</tr>
								<tr>
									<td>
										<h5>Công Suất</h5>
									</td>
									<td>
										<h5><asp:Label ID="lbl_Congsuat" runat="server"></asp:Label></h5>
									</td>
								</tr>
                                <tr>
                                    <td>MoMen Cực Đại</td>
                                    <td>
                                        <asp:Label ID="lbl_Momencucdai" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Dung Tích Nhớt</td>
                                    <td><asp:Label ID="lbl_Dungtichnhot" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>
                                        <h5>Loại Truyền Động</h5>
                                    </td>
                                    <td><asp:Label ID="lbl_Loaitruyendong" runat="server"></asp:Label></td>
                                </tr>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>
	</section>
</asp:Content>