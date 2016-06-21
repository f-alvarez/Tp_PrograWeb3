<%@ Page Language="C#" MasterPageFile="~/main/master/Cocinero.master" AutoEventWireup="true" CodeBehind="cancelar.aspx.cs" Inherits="Tp__PrograWeb3.main.cocineros.cancelar" %>

<%--

Dentro del listado de eventos, el cocinero podrá cancelar cualquier evento que aún no hayan
con fecha actual más un día. No se podrán cancelar eventos creados para hoy.
Aquellos eventos que ya estén cancelados o finalizados no deberán permitir la opción de
cancelar el evento.

Al momento de que el cocinero trate de cancelar un evento, se le deberá mostrar un popup
consultando si está seguro de cancelarlo y los botones “Confirmar”, “Cancelar”. (Se
recomienda el uso del popup de jquery UI).

Al hacer click en Confirmar se debe ejecutar una llamada de AJAX ​utilizando jquery que llame
a un servicio web de reservas /eventos.asmx/Cancelar​donde Cancelar es el nombre del
metodo y enviandole el id del evento (ejemplo de referencia
https://redk33.wordpress.com/2011/12/19/invocando­servicio­web­asmx­desde­jquery/ ). En el
método se debe validar que el usuario está logueado, que el evento es suyo, y las otra
validaciones mencionadas respecto de la fecha, en el caso de que alguna de estas cosas n
sea válida, mostrar un mensaje por pantalla (pueden escribir un <span> rojo). Recordar que
para tener acceso a la sesión desde el servicio se debe agregar [WebMethod(EnableSession =
true)]en el método.

Comentario: Al cancelar un evento se deberá cambiar el estado del mismo. No se deberá
eliminar el registro de la base de datos.--%>

<asp:Content ID="Content3" ContentPlaceHolderID="main" runat="Server">
    <div id="errorAjax" class="ErrorSpan"></div>
    <div class="panel panel-primary titles text-center">
        <div class="panel-heading">Eventos</div>
        <form runat="server">
            <ul class="list-group">
                <asp:Label ID="labelEventos" Text="No hay eventos para mostrar" runat="server" />
                <asp:Repeater ID="eventosId" runat="server">
                    <ItemTemplate>
                        <li class="list-group-item">
                            <div class="panel-body">
                                <p class="text-info"><b><%# Eval("nombre")%></b></p>
                                <p><%# Eval("fecha")%></p>
                                <p><%# Eval("descripcion")%></p>
                                <p>Cantidad máxima: <%# Eval("cantidadComensales")%></p>
                                <p>Cantidad de reservas: <%# Eval("cantidadReservas")%></p>
                                <p class='<%# Eval("EstadoString") == "Cancelado" ? "text-danger" : Eval("EstadoString") == "Pendiente" ? "text-success":"text-info" %>'><%# Eval("estadoString")%></p>
                                <asp:LinkButton ID="LinkButton1" Visible='<%# string.Equals(Eval("estadoString"),"Pendiente") %>' CommandArgument='<%#  DataBinder.Eval(Container.DataItem, "IdEvento")%>'                                              runat="server" OnClick="btnShowPopup_Click">
                                                    Cancelar
                                </asp:LinkButton>
                            </div>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </form>
    </div>
    <div id="dialog"></div>
</asp:Content>
