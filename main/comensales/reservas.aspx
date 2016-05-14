<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="bodyComensales" runat ="server">

    <div class="col-md-12">
        <div class="text-center col-md-12">
            <h1>Mis Reservas</h1>
        </div>
        <form id="gv" class="form-horizontal" runat="server"  >
            <asp:GridView ID="gvListaEventos" runat="server" CssClass="table table-striped table-bordered table-condensed"  AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:HyperLinkField NavigateUrl="~/main/comensales/comentarios.aspx" Text="Calificar" />
                </Columns> 
            </asp:GridView> 
        </form>
    </div>

</asp:Content>