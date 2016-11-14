<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Webforms.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ItemType="Webforms.Models.ProductModel" RenderOuterTable="false" SelectMethod="product_GetItem" >
        <EmptyDataTemplate>
            <h3>We are unable to find any data.</h3>
        </EmptyDataTemplate>
        
        <ItemTemplate>
            <div>
                <h1><%#:Item.productName%></h1>
                <h2><%#:Item.cataory.CategoryName%></h2>
            </div>
            <div>
                <p><%#:Item.description%></p>
                <p>£<%#:Item.unitPrice%></p>
            </div>

        </ItemTemplate>
    </asp:FormView>
</asp:Content>
