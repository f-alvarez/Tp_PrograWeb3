<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Anonimo.Master" AutoEventWireup="true" CodeBehind="comentarios.aspx.cs" Inherits="Tp__PrograWeb3.main.anonimo.comentarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyAnonimo" runat="server">

    <div class="col-md-12">
        <div class="text-center col-md-12">
            <h1>Mis Reservas</h1>
        </div>
        <form id="gv" class="form-horizontal" runat="server">

            <asp:Repeater ID="comentariosRepeater" runat="server">
                <ItemTemplate>
                    <li class="list-group-item">
                        <div class="panel-body">
                            <p>Calificacion: <b class="puntuacion"><%# Eval("Puntuacion")%></b></p>
                            <p>Comentario: <%# Eval("Comentarios1")%></p>
                            <p><b>Usuario: @<%# Eval("nombreUsuario")%></b></p>

                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
            <asp:HyperLink href="default.aspx" ID="HyperLink1" runat="server">Volver</asp:HyperLink>
        </form>
    </div>

</asp:Content>
