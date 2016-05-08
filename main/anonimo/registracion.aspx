﻿<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Anonimo.master" AutoEventWireup="true" CodeBehind="registracion.aspx.cs"  Inherits="Tp__PrograWeb3.main.registracion" %>

<%@ Register Src="~/main/userControls/ucLabelTexto.ascx" TagPrefix="uc1" TagName="ucLabelTexto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyAnonimo" runat="server">
<div class="ContenedorFormulario">
<div class="ContenedorFormularioInterior">
    <form id="Form1" class="form-horizontal" runat="server">
        <div class="form-group">
            <uc1:ucLabelTexto runat="server" ID="ucLabelTextoNombre" TextoLabel="Nombre" TxtType="SingleLine"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un nombre" Display="Dynamic" ControlToValidate="ucLabelTextoNombre$txt" CssClass="help-block"></asp:RequiredFieldValidator>
            </div>
        <%--Cierro DIV del userControl--%>
        </div>
         <div class="form-group">
            <uc1:ucLabelTexto runat="server" ID="ucLabelTextoEmail" TextoLabel="Email" TxtType="Email"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Ingrese un email" Display="Dynamic" ControlToValidate="ucLabelTextoEmail$txt" CssClass="help-block"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="Ingrese email valido"
                ControlToValidate="ucLabelTextoEmail$txt"
                ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" Display="Dynamic" CssClass="help-block">
            </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <uc1:ucLabelTexto runat="server" ID="ucLabelTextoPass" TextoLabel="Password" TxtType="Password"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingrese una contraseña" Display="Dynamic" ControlToValidate="ucLabelTextoPass$txt" CssClass="help-block"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ErrorMessage="La contraseña debe empezar con 1 letra mayúscula y contener al menos 1 número"
                ControlToValidate="ucLabelTextoPass$txt"
                ValidationExpression="^([A-Z]{1})+([a-zA-Z0-9]*)$" Display="Dynamic" CssClass="help-block">
            </asp:RegularExpressionValidator>
        </div>
        </div>
        <div class="form-group">
            <uc1:ucLabelTexto runat="server" ID="ucLabelTextoConfirmPass" TextoLabel="Confirmar Password" TxtType="Password"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Confirme contraseña" Display="Dynamic" ControlToValidate="ucLabelTextoConfirmPass$txt" CssClass="help-block"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no coinciden" Display="Dynamic" ControlToValidate="ucLabelTextoConfirmPass$txt" CssClass="help-block"></asp:CompareValidator>
        </div>
        </div>
        <div class="form-group">
            <asp:RadioButtonList ID="RadioButtonTipoUser" runat="server" CssClass="center">
                <asp:ListItem Text="Comensal" Value="1"></asp:ListItem>
                <asp:ListItem Text="Cocinero" Value="2"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator CssClass="help-block centerText" ID="RequiredFieldValidator5" runat="server" 
                ErrorMessage="Elija un tipo de usuario" ControlToValidate="RadioButtonTipoUser"></asp:RequiredFieldValidator>
        </div>
        <!--BOTONES-->
		<div class="form-group">
		<label class="col-sm-4 control-label" for=""></label>	    
			<div class="col-sm-6">
				<button type="submit" id="btnSubmit" name="enviar" class="btn btn-success btn-md" value="Aceptar"><span class="glyphicon glyphicon glyphicon-ok-circle"></span> Aceptar</button>	
				<button type="reset" id="btnButton" name="cancelar" class="btn btn-danger btn-md" value="Cancelar"><span class="glyphicon glyphicon-remove-circle"></span> Cancelar</button>
			</div>
		</div>
</form>
    </div>
    </div>
</asp:Content>

