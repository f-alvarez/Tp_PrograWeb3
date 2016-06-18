<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Anonimo.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Tp__PrograWeb3.main.anonimo._default" %>

<%@ Register Src="~/main/userControls/ucEventosInicio.ascx" TagPrefix="uc1" TagName="ucEventosInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyAnonimo" runat="server">

        <asp:Label ID="labelEventos" Text="No hay eventos para mostrar" CssClass="col-sm-12" runat="server" />
    
            <asp:Repeater id="eventosId" runat="server">                            
                <ItemTemplate>
                    <div class="col-sm-4">
                        <uc1:ucEventosInicio runat="server" ID="ucEventosInicio" 
                            LabelPuntuacion="4.3" 
                            LabelPrecio='<%# Eval("precio")%>'
                            urlLink="~/main/anonimo/comentarios.aspx"
                            imgSrcUrl='<%# Eval("NombreFoto")%>'
                            imgLink="~/main/anonimo/comentarios.aspx"
                            TextLink='<%# Eval("Nombre")%>'/>                     
                    </div>
    
                </ItemTemplate>
            
            </asp:Repeater>

</asp:Content>
