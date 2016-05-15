<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuComensal.ascx.cs" Inherits="Tp__PrograWeb3.main.ucMenuComensal" %>


<header>
    <nav class="navbar navbar-default" role="navigation">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navegacion" ><!--NAVEGACION-->
					<span class="sr-only">Desplegar / Ocultar Men&uacute;</span>
					<span class="glyphicon glyphicon-menu-hamburger"></span>
				</button>
			</div>
		
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">Comensal</a>
    </div>
    <ul class="nav navbar-nav">
        <li><a href="reservas.aspx">Mis reservas</a></li>                  
        <li><a href="reservar.aspx">Reservar Evento</a></li>
        <li><a id="A1" href="#" runat="server" onserverclick="Logout">Cerrar Sesión</a></li>
    </ul>
  </div>
</nav>
				
</header>