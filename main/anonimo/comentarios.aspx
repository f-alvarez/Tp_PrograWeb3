<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Anonimo.Master" AutoEventWireup="true" CodeBehind="comentarios.aspx.cs" Inherits="Tp__PrograWeb3.main.anonimo.comentarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyAnonimo" runat="server">

<div class="col-md-12">

        <div class="text-center col-md-12">
            <h1>COMENTARIOS</h1>
        </div>


        <div class="col-md-12">
            <form id="gv" class="form-horizontal" runat="server">
                <div class="panel panel-primary titles ">
                    <div class="panel-heading text-center">
                        <h3>
                            <asp:Label ID="lblevento" runat="server" Text=""></asp:Label></h3>
                    </div>
                    <div class="panel text-center">
                        <h4>Cocinero:
                            <asp:Label ID="lblnombre" runat="server" Text=""></asp:Label></h4>
                    </div>
                    <div class="text-left">
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
                    </div>
                </div>
                <asp:HyperLink href="default.aspx" ID="HyperLink1" runat="server">Volver</asp:HyperLink>

            </form>
        </div>
    </div>


</asp:Content>
