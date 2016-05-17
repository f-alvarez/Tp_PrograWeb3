<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Anonimo.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Tp__PrograWeb3.main.anonimo._default" %>

<%@ Register Src="~/main/userControls/ucEventosInicio.ascx" TagPrefix="uc1" TagName="ucEventosInicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyAnonimo" runat="server">
    
        <div class="col-sm-4">
            <uc1:ucEventosInicio runat="server" ID="ucEventosInicio" 
                LabelPuntuacion="4.3" 
                LabelPrecio="280"
                urlLink="~/main/anonimo/comentarios.aspx"
                imgSrcUrl="../../resources/img/01.jpg"
                imgLink="~/main/anonimo/comentarios.aspx"
                TextLink="Sushi: Alaska Roll"/>
        </div>

         <div class="col-sm-4">
            <uc1:ucEventosInicio runat="server" ID="ucEventosInicio1"
                LabelPuntuacion="4.5" 
                LabelPrecio="300"
                urlLink="~/main/anonimo/comentarios.aspx"
                imgSrcUrl="../../resources/img/02.jpg"
                imgLink="~/main/anonimo/comentarios.aspx"
                TextLink="Festival Raíz" />
        </div>

         <div class="col-sm-4">
            <uc1:ucEventosInicio runat="server" ID="ucEventosInicio2" 
                LabelPuntuacion="4.4" 
                LabelPrecio="250"
                urlLink="~/main/anonimo/comentarios.aspx"
                imgSrcUrl="../../resources/img/03.jpg"
                imgLink="~/main/anonimo/comentarios.aspx"
                TextLink="El Sabor de los Chiles"/>
        </div>

         <div class="col-sm-4">
            <uc1:ucEventosInicio runat="server" ID="ucEventosInicio3" 
                LabelPuntuacion="5.0" 
                LabelPrecio="750"
                urlLink="~/main/anonimo/comentarios.aspx"
                imgSrcUrl="../../resources/img/04.jpg"
                imgLink="~/main/anonimo/comentarios.aspx"
                TextLink="Wine and Food Festival"/>
        </div>

         <div class="col-sm-4">
            <uc1:ucEventosInicio runat="server" ID="ucEventosInicio4" 
                LabelPuntuacion="4.9" 
                LabelPrecio="700"
                urlLink="~/main/anonimo/comentarios.aspx"
                imgSrcUrl="../../resources/img/05.jpg"
                imgLink="~/main/anonimo/comentarios.aspx"
                TextLink="Eat Drink SF"/>
        </div>

         <div class="col-sm-4">
            <uc1:ucEventosInicio runat="server" ID="ucEventosInicio5"
                LabelPuntuacion="4.1" 
                LabelPrecio="80"
                urlLink="~/main/anonimo/comentarios.aspx"
                imgSrcUrl="../../resources/img/06.jpg"
                imgLink="~/main/anonimo/comentarios.aspx"
                TextLink="Pad Thai" />
        </div>

</asp:Content>
