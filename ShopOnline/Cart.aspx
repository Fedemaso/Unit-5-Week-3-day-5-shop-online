<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ShopOnline.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center my-4" style="color:white; font-size:2em ">Carrello</h1>
   

    <asp:Button ID="HomeButton" runat="server" Text="Home" OnClick="HomeButton_Click"  CssClass="btn btn-secondary"/>
    <asp:Button ID="ClearCartButton" runat="server" Text="Svuota Carrello" OnClick="ClearCartButton_Click"  CssClass="btn btn-secondary"/>
<asp:GridView ID="CartGridView" style="color:white" class="my-5 text-center" runat="server" AutoGenerateColumns="False" ShowHeader="true">
    <Columns >
        <asp:BoundField HeaderText="Nome Prodotto" DataField="Name" />
        <asp:BoundField HeaderText="Prezzo" DataField="Price" DataFormatString="{0:C}" />
        <asp:TemplateField HeaderText="Azione">
            <ItemTemplate>
               

                <asp:Button ID="RemoveItemButton" runat="server" Text="Elimina" OnClick="RemoveItemButton_Click" CommandArgument='<%# Eval("Id") %>' CssClass=" mx-4 btn btn-secondary" />
                
            </ItemTemplate>
            
        </asp:TemplateField>
    </Columns>
</asp:GridView>

    <asp:Table ID="Table1" runat="server"></asp:Table>

</asp:Content>
