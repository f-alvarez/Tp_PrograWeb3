<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="bodyComensales" runat="server">

    <div class="row">
        <div class="text-center col-md-12">
            <h1>Mis Reservas</h1>
        </div>
    </div>
        <form id="gv" class="form-horizontal" runat="server">

            <asp:Repeater ID="eventosReservadosId" runat="server">
                <ItemTemplate>
                    <div class='well well-lg <%# (byte)Eval("estado") == 2 ? "panel-body cancelado":"panel-body"%>'>
                        <div >
                            <h4><p class="titulo" >Evento: <%# Eval("nombre")%></p></h4>
                            <p><%# Eval("fecha")%></p>
                            <p><%# Eval("descripcion")%></p>
                            <p class='<%# Eval("EstadoString") == "Cancelado" ? "text-danger" : Eval("EstadoString") == "Pendiente" ? "text-success":"text-warning" %>'><%# Eval("EstadoString")%></p>
                            <div>  
                            <asp:LinkButton ID="LinkButton1" Visible='<%# (byte)Eval("estado") == 3 && !(bool)Eval("eventoComentado") %>'
                              href='<%# Eval("IdEvento","./comentarios.aspx?eventoId={0}") %>' 
                              runat="server">Calificar</asp:LinkButton>                                        
                            </div>
                        </div>
                   </div>
                </ItemTemplate>
            </asp:Repeater>
        </form>
</asp:Content>
