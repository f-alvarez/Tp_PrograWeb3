<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservar.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservar" %>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyComensales" runat="server">
    <div class="row">
        <div class="text-center col-md-12">
            <h1>Reservar</h1>
        </div>
    </div>
    <form id="gv" class="form-horizontal" runat="server">
        <div class="well well-lg">
            <asp:GridView ID="gvListaEventosAReservar" runat="server" CssClass="table table-bordered table-condensed" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="cantidadComensales" HeaderText="Cantidad de comensales" />
                    <asp:BoundField DataField="ubicacion" HeaderText="Ubicación" />
                    <asp:ImageField DataImageUrlField="NombreFoto"
                        DataImageUrlFormatString="~/resources/img/{0}"
                        AlternateText="Foto Evento"
                        NullDisplayText="Imagen no encontrada"
                        HeaderText="Foto"
                        ReadOnly="true" ControlStyle-CssClass="imgWidth" />
                    <asp:BoundField DataField="precio" HeaderText="Precio" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                    <asp:BoundField DataField="estadoString" HeaderText="Estado" />
                    <asp:HyperLinkField Text="Concurrir" ControlStyle-CssClass="btn btn-success" DataNavigateUrlFields="idEvento" DataNavigateUrlFormatString="reservarEvento.aspx?idEvento={0}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</asp:Content>
