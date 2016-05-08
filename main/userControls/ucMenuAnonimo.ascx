<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuAnonimo.ascx.cs" Inherits="Tp__PrograWeb3.main.userControls.ucMenuAnonimo" %>

<header>
    <nav class="navbar navbar-default" role="navigation">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navegacion" ><!--NAVEGACION-->
					<span class="sr-only">Desplegar / Ocultar Men&uacute;</span>
					<span class="glyphicon glyphicon-menu-hamburger"></span>
				</button>
			</div>
		<div class="container"> <!--CONTAINER-->			
			<!--INICIA MENU-->
			<div class="collapse navbar-collapse" id="navegacion"><!--NAVEGACION-->
                <div class="navbar-header">
                    <a class="navbar-brand" href="default.aspx">Inicio</a>
                </div>
				<ul class="pull-right nav navbar-nav">
					<li><a href="login.aspx">Ingresar</a></li>
					<li><a href="registracion.aspx">Registro</a></li>
				</ul>
			</div>
		</div>
	</nav>
</header>