<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Elven Toys</h1>
    </div>
    <div>
        <asp:ListView ID="ListView1" runat="server" ItemType="Webforms.Models.catagoryModel" SelectMethod="ListView1_GetData" OnCallingDataMethods="ListView1_CallingDataMethods">
            <EmptyDataTemplate>
                <h3>Oops we have no products for sale.</h3>
            </EmptyDataTemplate>
            <ItemTemplate>
                <b><a href="/ProductList.aspx?id=<%#:Item.CategoryID %>">
                    <%#:Item.CategoryName %> 
                </a></b>
            </ItemTemplate>
            <ItemSeparatorTemplate>
                /
            </ItemSeparatorTemplate>
        </asp:ListView>
    </div>
    <div>
        <h1>Welcome to the North Pole Market </h1>
        <p>The elves are hard at work and have made toys to sell for all the girls and boys. We love making toys for all the little girls and boys.</p>
    </div>
</asp:Content>

