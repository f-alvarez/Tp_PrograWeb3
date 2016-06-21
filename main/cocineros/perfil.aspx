<%@ Page Language="C#" MasterPageFile="~/main/master/Cocinero.master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="Tp__PrograWeb3.main.cocineros.perfil" %>

<%--El cocinero dentro de su perfil podrá ver la fecha de registración, su email y la cantidad de
recetas creadas. Además, podrá ver el listado de sus recetas y de sus eventos.
El listado de las recetas deberá mostrar todos los campos con los cuales han sido creadas.
El listado de los eventos deberá mostrar el nombre, la fecha, la descripción, la cantidad máxima
de comensales, la cantidad de reservas realizadas y el estado del evento (finalizado, cancelado,pendiente).--%>

<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
    <div class="col-md-12">
        <div class="text-center col-md-12">
            <h1>PERFIL</h1>
        </div>
        <div class="col-md-6">
            <div class="col-md-12">
                <div class="panel panel-primary titles text-center">
                    <div class="panel-heading">Eventos</div>
                    <ul class="list-group">
                        <asp:Label ID="labelEventos" Text="No hay eventos para mostrar" runat="server" />
                        <asp:Repeater id="eventosId" runat="server">                            
                            <ItemTemplate>                              
                                    <div class="well well-lg">                      
                                        <p class="titulo"><%# Eval("nombre")%></p>
                                        <p><%# Eval("fecha")%></p>
                                        <p><%# Eval("descripcion")%></p>
                                        <p>Cantidad máxima: <%# Eval("cantidadComensales")%></p>
                                        <p>Cantidad de reservas: <%# Eval("cantidadReservas")%></p>
                                        <p class='<%# Eval("EstadoString") == "Cancelado" ? "text-danger" : Eval("EstadoString") == "Pendiente" ? "text-success":"text-warning" %>'>
                                            <%# Eval("estadoString")%>
                                        </p>
                                    </div>                                                         
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
        <div class="col-md-6 text-center">
            <div class="col-md-12">
                <div class="panel panel-primary titles text-center">
                    <div class="panel-heading">Datos</div>
                    <div class="panel-body">
                        <div class="col-md-12">
                            <div class="portrait">
                                <img class="img-circle img-responsive" src="http://lorempixel.com/400/400/people/" alt="portrait" />
                            </div>
                        </div>

                        <div class="col-md-12 text-center">
                            <p><asp:Label id="nombreId" Text="" runat="server" /></p>
                            <p>Miembro desde: <asp:Label id="fechaIngresoId" Text="" runat="server" /></p>
                            <p><asp:Label id="mailId" Text="" runat="server" /></p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-12">
                <div class="panel panel-primary titles text-center">
                    <div class="panel-heading">Recetas</div>
                    <ul class="list-group">
                        <asp:Label ID="labelRecetas" Text="No hay recetas para mostrar" runat="server" />
                        <asp:Label ID="labelCantidadRecetas" Text="Cantidad de Recetas: " runat="server" />

                            <asp:Repeater id="recetasId" runat="server">
                                <ItemTemplate>
                                 
                                        <div class="well well-lg">
                                            <p class="titulo"><%# Eval("nombre")%></p>
                                            <p>Tipo: </b><%# Eval("TipoString")%></p>
                                            <p>Descripcion: </b><%# Eval("descripcion")%></p>
                                            <p>Ingredientes: </b><%# Eval("ingredientes")%></p>
                                            <p>Tiempo de Coccion: </b><%# Eval("tiempoCoccion")%> minutos</p>
                                        </div>
                              
                                    
                                </ItemTemplate>
                            </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


