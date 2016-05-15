<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuCocinero.ascx.cs" Inherits="Tp__PrograWeb3.main.ucMenuCocinero" %>


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
      <a class="navbar-brand" href="#">Cocineros</a>
    </div>
    <ul class="nav navbar-nav">
      <li class="active"><a href="perfil.aspx​">Mi Perfil</a></li>
                  
					<li><a href="recetas.aspx">Crear Recetas</a></li>
                    <li><a href="eventos.aspx">Crear Eventos de Cocina</a></li>
                    <li><a href="cancelar.aspx">Cancelar Eventos</a></li>
    </ul>
  </div>
</nav>
				
</header>