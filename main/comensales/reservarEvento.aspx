<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservarEvento.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservarEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyComensales" runat="server">
    <asp:Repeater id="RecetasRepeater" runat="server">                            
        <ItemTemplate>
            <li class="list-group-item">
                <div class="panel-body">                      
                    <p><b><%# Eval("nombre")%></b></p>
                </div>     
            </li>                       
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
