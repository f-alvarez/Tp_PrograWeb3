<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Anonimo.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Tp__PrograWeb3.main.login" %>

<%@ Register Src="~/main/userControls/ucLabelTexto.ascx" TagPrefix="uc1" TagName="ucLabelTexto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyAnonimo" runat="server">
<div class="ContenedorFormulario">
<div class="ContenedorFormularioInterior">
    <form id="Form1" class="form-horizontal" runat="server">
        <div class="form-group">
            <uc1:ucLabelTexto runat="server" ID="ucLabelTextoEmail" TextoLabel="Email" TxtType="Email"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un email" Display="Dynamic" ControlToValidate="ucLabelTextoEmail$txt" CssClass="help-block"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="Ingrese email valido"
                ControlToValidate="ucLabelTextoEmail$txt"
                ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" Display="Dynamic" CssClass="help-block">
            </asp:RegularExpressionValidator>
            </div>
        <%--Cierro DIV del userControl--%>
        </div>
        <div class="form-group">
            <uc1:ucLabelTexto runat="server" ID="ucLabelTextoPass" TextoLabel="Password" TxtType="Password"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingrese una contraseña" Display="Dynamic" ControlToValidate="ucLabelTextoPass$txt" CssClass="help-block"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
		<label class="col-sm-4 control-label" for=""></label>	    
			<div class="col-sm-6">
				<button type="submit" class="btn btn-primary">Ingresar</button>	
			</div>
		</div>
</form>
    </div>
    </div>
</asp:Content>
