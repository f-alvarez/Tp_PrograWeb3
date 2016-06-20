<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="bodyComensales" runat="server">

    <div class="col-md-12">
        <div class="text-center col-md-12">
            <h1>Mis Reservas</h1>
        </div>
        <form id="gv" class="form-horizontal" runat="server">

            <asp:Repeater ID="eventosReservadosId" runat="server">
                <ItemTemplate>
                    <li class="list-group-item">
                        <div class='<%# (byte)Eval("estado") == 2 ? "panel-body cancelado":"panel-body"%>'>
                            <p><b><%# Eval("nombre")%></b></p>
                            <p><%# Eval("fecha")%></p>
                            <p><%# Eval("descripcion")%></p>
                            <p>Estado: <%# Eval("EstadoString")%></p>
                            <div>  
                            <asp:LinkButton ID="LinkButton1" Visible='<%# (byte)Eval("estado") == 3 && !(bool)Eval("eventoComentado") %>'
                              href='<%# Eval("IdEvento","./comentarios.aspx?eventoId={0}") %>' 
                              runat="server">Calificar</asp:LinkButton>                                        
                            </div>
                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </form>
    </div>
</asp:Content>
