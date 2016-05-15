<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservarEvento.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservarEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyComensales" runat="server">
    <form id="gv" class="form-horizontal" runat="server"  >
        <asp:GridView ID="gvListaRecetas" runat="server" CssClass="table table-striped table-bordered table-condensed"  AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="ingredientes" HeaderText="Ingredientes" />
                <asp:BoundField DataField="recetaId" HeaderText="Estado" />
            </Columns> 
        </asp:GridView> 
        <asp:TextBox ID="cantidadComensales" runat="server"></asp:TextBox>
        <asp:Button ID="btnReceta" runat="server" Text="Button" OnClick="btnReceta_Click1" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</asp:Content>
