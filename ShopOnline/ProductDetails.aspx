<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ShopOnline.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center my-4" style="color:white; font-size:2em;">Dettagli Prodotto</h1>
    <div class="text-center m-5">
        <asp:Button ID="GoToCartButton" runat="server" Text="Vai al Carrello" OnClick="GoToCartButton_Click" CssClass="btn btn-secondary" />
        <asp:Button ID="HomeButton" runat="server" Text="Home" OnClick="HomeButton_Click" CssClass="btn btn-secondary" />

    </div>
    <div class="product-details">
        <asp:Image ID="ProductImage" runat="server" CssClass="img-fluid rounded mx-auto d-block" />
        <h2 class="text-center" style="color:white"><asp:Label ID="ProductNameLabel" runat="server" CssClass="h4" /></h2>
        <p class="text-center" style="color:white"><asp:Label ID="ProductDescriptionLabel" runat="server" CssClass="lead" /></p>
        <p class="text-center" style="color:white"><asp:Label ID="ProductPriceLabel" runat="server" CssClass="h5" /></p>
        

        <div class="text-center">
            <asp:Button ID="AddToCartButton" runat="server" Text="Aggiungi al Carrello" OnClick="AddToCartButton_Click" CssClass="btn btn-secondary" />
            
        </div>
    </div>
</asp:Content>

