<%@ Page Title="ProductList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Webforms.ProductList" %>
<asp:Content ID="ProductList" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <h1 class=" small-8 small-centered columns">Product List</h1>
        </div>
    <asp:ListView runat="server" ID="productListView" ItemType="Webforms.Models.ProductModel" SelectMethod="listProducts" OnCallingDataMethods="productListView_CallingDataMethods" GroupItemCount="4">
        <EmptyDataTemplate>
            <table>
                <tr>
                    <td>No data has been recived.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
        <ItemTemplate>
            <td runat="server">
                <table>                   
                    <tr>
                        <td>
                            <span><%#:Item.productName %></span>
                            <p>£<%#:Item.unitPrice %></p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="button" href="/ProductDetails.aspx?productID=<%#:Item.productId%>">Click me for more details</a>
                        </td>
                    </tr>
                </table>
            </td>
        </ItemTemplate>
        <LayoutTemplate>
            <table id="groupPlaceholderContainer" runat="server" class="small-8 small-centered columns">
                <tr id="groupPlaceholder"></tr>
            </table>
        </LayoutTemplate>
    </asp:ListView>

</asp:Content>
