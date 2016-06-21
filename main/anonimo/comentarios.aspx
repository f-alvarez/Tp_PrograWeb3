<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Anonimo.Master" AutoEventWireup="true" CodeBehind="comentarios.aspx.cs" Inherits="Tp__PrograWeb3.main.anonimo.comentarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyAnonimo" runat="server">

    <div class="col-md-12">
        <div class="row">
        <div class="text-center col-md-12">
            <h2>COMENTARIOS</h2>
        </div>
        </div>

        <div class="col-md-12">
            <form id="gv" class="form-horizontal" runat="server">

                <div class="jumbotron">
                    <h3>Evento: 
                        <asp:Label ID="lblevento" runat="server" Text=""></asp:Label>
                    </h3>
                    <h4>Cocinero: 
                        <asp:Label ID="lblnombre" runat="server" Text=""></asp:Label>
                    </h4>
                </div>
               
                <div class="text-left">
                    <asp:Repeater ID="comentariosRepeater" runat="server">
                        <ItemTemplate>
                            <div class="well well-lg">
                                <p><b>Usuario: @<%# Eval("nombreUsuario")%></b></p>
                                <p>Calificacion: <b class="puntuacion"><%# Eval("Puntuacion")%></b></p>
                                <p>Comentario: <%# Eval("Comentarios1")%></p>                               
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/main/anonimo/default.aspx">Volver</asp:HyperLink>

            </form>
        </div>
    </div>


</asp:Content>
