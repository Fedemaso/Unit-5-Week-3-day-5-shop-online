<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShopOnline.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center my-4" style="color:white; font-size:2em ">Prodotti</h1>
    <div class="product-list">
        <div class="container">
    <div class="row">
        <asp:Repeater ID="ProductRepeater" runat="server">
            <ItemTemplate>
                <div class="col-md-4 mb-4">
                    <div class="card m-5" >
                        <img class="card-img-top" style="height:200px; width:auto" src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>' />
                        <div style="background-color:gray"; class="card-body">
                            <h5 class="card-title"><%# Eval("Name") %></h5>
                            <p class="card-text"><%# Eval("Price", "{0:C}") %></p>
                            <a href='<%# "ProductDetails.aspx?Id=" + Eval("Id") %>' class="btn btn-secondary">Dettagli</a>
                            <asp:Button ID="GoToCartButton" runat="server" Text="Vai al Carrello" OnClick="GoToCartButton_Click" CssClass="btn btn-secondary" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>

    </div>
</asp:Content>
