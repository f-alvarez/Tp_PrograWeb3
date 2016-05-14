<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="bodyComensales" runat ="server">

     <div class="col-md-12">
        <div class="text-center col-md-12">
            <h1>MIS RESERVAS</h1>

         </div>
         <form id="gv" class="form-horizontal" runat="server">
        <asp:GridView ID="gvListaEventos" runat="server" CssClass="table table-striped table-bordered table-condensed">
        </asp:GridView>
    </form>
    </div>
    </div>
</asp:Content>