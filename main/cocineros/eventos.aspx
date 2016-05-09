<%@ Page Language="C#" MasterPageFile="~/main/master/Cocinero.master" AutoEventWireup="true" CodeBehind="eventos.aspx.cs"  Inherits="Tp__PrograWeb3.main.cocineros.eventos" %>


<%--El cocinero creará eventos en donde cocinará alguna de las recetas que ya tiene vinculadas en
su perfil dentro del sistema. En los eventos, los cocineros harán uno o varios de sus recetas
para una cantidad de comensales defina por él.

Al momento de crear un evento deberá cargar:
­ -nombre del evento.
­ -fecha del evento.
­ -descripción.
­ -recetas propuestas para el evento.
­ -cantidad máxima de comensales.
­ -ubicación (dirección)
­ -foto del evento.
­ -precio (valor decimal)

Todos los campos son obligatorios y deberán ser validados. X

El cocinero deberá al menos seleccionar una (pueden ser varias) de sus recetas para el evento.

La cantidad de comensales será para todo el evento y no por receta.

Para la carga de la imagen deberán utilizar el control asp.net llamado UploadFile. El archivo
deberá quedar alojado en una carpeta física dentro de la aplicación (\fotos). Contemplar que al
momento de guardar la imagen, quede almacenado con un nombre único (1)​.

Al momento de crear el evento, se deberá guardar el estado del mismo. El estado de un evento
recién creado es pendiente.

La fecha del evento tiene que ser mayor al día actual. No se podrán crear eventos en fecha
pasada. En caso de que el cocinero, ingrese una fecha inválida, la misma deberá ser validada
por la aplicación.

El precio será un valor decimal de dígitos obligatorio. Debe ser mayor a 0(cero). No se permiten
eventos gratuitos. X

(1) ​una opción es usando Guid.NewGuid().ToString() + extensión de la imagen y guardar en el
campo Foto en la base de datos el Path relativo.--%>


<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
    <div class="col-md-12">
        <div class="text-center col-md-12">
            <h1>EVENTOS</h1>
        </div>
        <form id="Form1" class="form" runat="server">
          <div class="form-group col-md-6">
            <label>Nombre del evento:</label>
            <input type="text" class="form-control" runat="server" id="nombreId" placeholder="Ingrese nombre">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="nombreId" CssClass="has-error">
                <span class="help-block">Ingrese un nombre</span>
            </asp:RequiredFieldValidator>
          </div>

          <div class="form-group col-md-6">
            <label>Fecha del evento:</label>
            <input type="text" class="form-control" id="fechaId" placeholder="dd/mm/yyyy" runat="server">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="fechaId" ValidationExpression="(((0|1)[1-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"
            ValidationGroup="Group1" CssClass="has-error">
                <span class="help-block">Ingrese una fecha válida</span>
            </asp:RegularExpressionValidator>
            
            <asp:CompareValidator ID="Comparevalidator1" runat="server" 
            controltovalidate="fechaId" type="String"
            valuetocompare="0" CssClass="has-error">
                <span class="help-block">La fecha no puede ser menor al día de hoy</span>
            </asp:CompareValidator>
            
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="fechaId" CssClass="has-error">
                <span class="help-block">Ingrese una fecha</span>
            </asp:RequiredFieldValidator>

          </div>
          
          <div class="form-group col-md-12">
            <label>Descripción:</label>
            <textarea class="form-control" rows="5" id="descripcionId" placeholder="Ingrese Descripción" runat="server">

            </textarea>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ControlToValidate="descripcionId" CssClass="has-error">
                <span class="help-block">Ingrese una descripcion</span>
            </asp:RequiredFieldValidator>

          </div>            

          <div class="form-group col-md-6">
            <label>Recetas propuestas:</label>

              <div class="checkbox">
                <label><input type="checkbox" name="receta" value="0" />Sopa</label>
              </div>
              <div class="checkbox">
                <label><input type="checkbox" name="receta" value="1" />Una receta que ya está creada.</label>
              </div>
          </div>

          <div class="form-group col-md-6">
            <label>Cantidad máxima de comensales:</label>
              <input type="number" class="form-control" id="comensalesId" runat="server" min="0">

            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic" ControlToValidate="comensalesId" CssClass="has-error">
                    <span class="help-block">Seleccione la cantidad de comensales</span>
            </asp:RequiredFieldValidator>
          </div>

          <div class="form-group col-md-6">
            <label>Ubicación:</label>
            <input type="text" class="form-control" placeholder="Ingrese ubicación" runat="server" id="ubicacionId">
              
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ControlToValidate="ubicacionId" CssClass="has-error">
                <span class="help-block">Ingrese la ubicación</span>
            </asp:RequiredFieldValidator>
          </div>

          <div class="form-group col-md-6">
            <label>Foto:</label>
            <asp:FileUpload id="fotoId" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Display="Dynamic" ControlToValidate="fotoId" CssClass="has-error">
                <span class="help-block">Ingrese la ubicación</span>
            </asp:RequiredFieldValidator>
          </div>

            
          <div class="form-group col-md-6">
            <label>Precio:</label>
            <input type="number" class="form-control" id="precioId" runat="server">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic" ControlToValidate="precioId" CssClass="has-error">
                    <span class="help-block">Ingrese el precio</span>
            </asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator runat="server" id="rexNumber" controltovalidate="precioId" validationexpression="^\d+(\.\d{1,2})?$" >
                <span class="help-block">El precio debe ser mayor a 0</span>
            </asp:RegularExpressionValidator>
          </div>
               
          <div class="form-group col-md-12">
            <button type="submit" class="btn btn-success pull-right">Guardar Evento</button>
          </div>                     
        </form>
    </div>
</asp:Content>
