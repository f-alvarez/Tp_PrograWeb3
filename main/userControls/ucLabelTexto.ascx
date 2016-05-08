<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLabelTexto.ascx.cs" Inherits="Tp__PrograWeb3.main.userControls.ucLabelTexto" %>


    <asp:Label ID="lbl" AssociatedControlId="txt" runat="server" CssClass="col-xs-4 control-label"></asp:Label>
    <div class="col-xs-7">
        <asp:TextBox ID="txt" runat="server" CssClass="form-control"></asp:TextBox>
    <%--Dejo DIV abierto para que las validacion queden prolijas--%>