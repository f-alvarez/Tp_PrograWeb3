<%@ Page Language="C#" MasterPageFile="~/main/master/Cocinero.master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="Tp__PrograWeb3.main.cocineros.perfil" %>

<%--El cocinero dentro de su perfil podrá ver la fecha de registración, su email y la cantidad de
recetas creadas. Además, podrá ver el listado de sus recetas y de sus eventos.
El listado de las recetas deberá mostrar todos los campos con los cuales han sido creadas.
El listado de los eventos deberá mostrar el nombre, la fecha, la descripción, la cantidad máxima
de comensales, la cantidad de reservas realizadas y el estado del evento (finalizado, cancelado,pendiente).--%>

<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
    <div class="col-md-12">
        <div class="col-md-6">
            <div class="col-md-12">
                <div class="panel panel-default titles text-center">
                    <div class="panel-heading">Eventos</div>
                    <ul class="list-group">
                        <li class="list-group-item">
                            <div class="panel-body">
                                <p><b>Cocina Chano</b></p>
                                <p>Fecha: 21/09/16</p>
                                <p>En la cocina para Chano no vas a comer nada</p>
                                <p>Cantidad máxima: 40 comensales</p>
                                <p>Cantidad de reservas: 0 comensales</p>
                                <p>Estado: Pendiente</p>
                                <div class="text-right">
                                     <a class="text-right" href="#">Opciones</a>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="col-md-12">
                <div class="panel panel-default titles text-center">
                    <div class="panel-heading">Recetas</div>
                    <ul class="list-group">
                        <li class="list-group-item">Arroz con queso</li>
                        <li class="list-group-item">Fideos con queso</li>
                        <li class="list-group-item">Queso con queso</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="col-md-6 text-center">
            <div class="col-md-12">
                <div class="panel panel-default titles text-center">
                    <div class="panel-heading">Datos</div>
                    <div class="panel-body">
                        <div class="col-md-12">
                            <div class="portrait">
                                <img class="img-circle img-responsive" src="http://lorempixel.com/400/400/people/" alt="portrait" />
                            </div>
                        </div>

                        <div class="col-md-12 text-center">
                            <b>Juan Perez</b>
                            <p>Miembro desde: 12 de Abril de 1878</p>
                            <p>Correo: juanperez@gmail.com</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


