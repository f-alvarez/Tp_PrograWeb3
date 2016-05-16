<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservarEvento.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservarEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyComensales" runat="server">
    
    <div class="col-md-12">
        <h3>
            <asp:Label Text="" ID="eventoNombreLabel" runat="server" />
        </h3>
    </div>

    <form id="Form1" runat="server" >

        <div class="form-group col-md-6">
            <asp:Label ID="Label1" Text="Seleccione una receta" runat="server" />
            <asp:RadioButtonList CssClass="" runat="server" ID="recetasRadioListId">

            </asp:RadioButtonList>

            <asp:RequiredFieldValidator 
                ID="ReqiredFieldValidator1"
                runat="server"
                ControlToValidate="recetasRadioListId" CssClass="has-error">
                <span class="help-block">Seleccione una receta</span>
            </asp:RequiredFieldValidator>
        
        </div>

        <div class="form-group col-md-6">
            <label>Cantidad de comensales:</label>
              <input type="number" class="form-control" id="comensalesId" runat="server" min="0">

            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic" ControlToValidate="comensalesId" CssClass="has-error">
                    <span class="help-block">Seleccione la cantidad de comensales</span>
            </asp:RequiredFieldValidator>

            <asp:customvalidator id="CustomValidator1" Display="Dynamic" CssClass="has-error" onservervalidate="ValidateComensales" runat="server">
                <span class="help-block">La cantidad de comensales excede a la cantidad disponible</span>            
            </asp:customvalidator>

        </div>


        <div class="col-md-12">
            <asp:Button CssClass="btn btn-success" Text="Reservar" OnClick="Reservar" runat="server" />
        </div>
    </form>
</asp:Content>
