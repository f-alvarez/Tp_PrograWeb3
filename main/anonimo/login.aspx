<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Anonimo.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Tp__PrograWeb3.main.login" %>

<%@ Register Src="~/main/userControls/ucLabelTexto.ascx" TagPrefix="uc1" TagName="ucLabelTexto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyAnonimo" runat="server">
<div class="ContenedorFormulario">
<div class="ContenedorFormularioInterior">
    <form id="Form1" class="form-horizontal" runat="server">
        <asp:ValidationSummary ID="ResumenValidaciones" CssClass="alert alert-danger" runat="server"/>
        <div class="form-group">
            <uc1:ucLabelTexto runat="server" ID="ucLabelTextoEmail" TextoLabel="Email" TxtType="Email"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un email" Display="Dynamic" ControlToValidate="ucLabelTextoEmail$txt">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="Ingrese email valido"
                ControlToValidate="ucLabelTextoEmail$txt"
                ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" Display="Dynamic">
            *</asp:RegularExpressionValidator>
        </div>
        <div class="form-group">
            <uc1:ucLabelTexto runat="server" ID="ucLabelTextoPass" TextoLabel="Password" TxtType="Password"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingrese una contraseña" Display="Dynamic" ControlToValidate="ucLabelTextoPass$txt">*</asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
		<label class="col-sm-4 control-label" for=""></label>	    
			<div class="col-sm-6">
                <asp:Button ID="btnIngresarLogin" runat="server" CssClass="btn btn-primary" Text="Ingresar" OnClick="btnIngresarLogin_Click" />
			</div>
		</div>
</form>
</div>
</div>
</asp:Content>
