<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Publicpage.Master" AutoEventWireup="true" CodeBehind="Thungrac.aspx.cs" Inherits="GUI.Admin.Thungrac" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="content">
  <div id="content-header">
    <div id="breadcrumb"> <asp:Hyperlink runat="server" href="#" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i> Home</asp:Hyperlink> <asp:Hyperlink runat="server" href="#" class="current">Tables</asp:Hyperlink> </div>
    <h1>Tables</h1>
  </div>
        <div class="container-fluid">
    <hr/>
    <div class="row-fluid">
      <div class="span12">
          <div class="widget-title"> <span class="icon"> <i class="icon-th"></i> </span>
            <h5>Thung Rac</h5>
          </div>
        <div class="widget-content nopadding">
       <asp:GridView class="table table-bordered table-striped" ID="grvThungrac" runat="server" AutoGenerateColumns="False" Height="210px" Width="706px" OnRowCommand="grvThungrac_RowCommand" >
           <Columns>
               <asp:BoundField DataField="id" HeaderText="ID" SortExpression="id" />
               <asp:BoundField DataField="tensanpham" HeaderText="ten xe" SortExpression="tensanpham" /> 
               <asp:ImageField ControlStyle-Height="50" ControlStyle-Width="100" DataImageUrlField="anhminhhoa" DataImageUrlFormatString="../img/product/{0}" HeaderText="Ảnh">
<ControlStyle Height="50px" Width="100px"></ControlStyle>
               </asp:ImageField>
               
               <asp:BoundField DataField="giatien" HeaderText="Giá" SortExpression="Giá Tiền" />
               <asp:BoundField DataField="soluongtonkho" HeaderText="Số lượng" SortExpression="soluongtonkho" />
               
               <asp:BoundField DataField="ghichu" HeaderText="ghi chú" SortExpression="ghichu" />
               <asp:BoundField DataField="tenhanhxe" HeaderText="loại xe" SortExpression="tenhanhxe" />
               <asp:BoundField DataField="namsx" HeaderText="năm sản xuất" SortExpression="namsx" />
               <asp:TemplateField ShowHeader="false">
                   <ItemTemplate>
                       <asp:Button CssClass="btn btn-primary btn-mini" ID="btnKhoiphuc" runat="server" CausesValidation="false" Text="Khôi Phục" CommandName="KhoiphucSP" CommandArgument='<%# Eval("id") %>' />
                   </ItemTemplate>
               </asp:TemplateField>
               
               
           </Columns>
            
       </asp:GridView>

        </div>
        </div>
        </div>
        </div>
  </div>
</asp:Content>
