<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cancelar.aspx.cs" Inherits="Tp__PrograWeb3.main.cocineros.cancelar" %>

<%--

Dentro del listado de eventos, el cocinero podrá cancelar cualquier evento que aún no hayan
con fecha actual más un día. No se podrán cancelar eventos creados para hoy.
Aquellos eventos que ya estén cancelados o finalizados no deberán permitir la opción de
cancelar el evento.

Al momento de que el cocinero trate de cancelar un evento, se le deberá mostrar un popup
consultando si está seguro de cancelarlo y los botones “Confirmar”, “Cancelar”. (Se
recomienda el uso del popup de jquery UI).

Al hacer click en Confirmar se debe ejecutar una llamada de AJAX ​utilizando jquery que llame
a un servicio web de reservas /eventos.asmx/Cancelar​donde Cancelar es el nombre del
metodo y enviandole el id del evento (ejemplo de referencia
https://redk33.wordpress.com/2011/12/19/invocando­servicio­web­asmx­desde­jquery/ ). En el
método se debe validar que el usuario está logueado, que el evento es suyo, y las otra
validaciones mencionadas respecto de la fecha, en el caso de que alguna de estas cosas n
sea válida, mostrar un mensaje por pantalla (pueden escribir un <span> rojo). Recordar que
para tener acceso a la sesión desde el servicio se debe agregar [WebMethod(EnableSession =
true)]en el método.

Comentario: Al cancelar un evento se deberá cambiar el estado del mismo. No se deberá
eliminar el registro de la base de datos.--%>
