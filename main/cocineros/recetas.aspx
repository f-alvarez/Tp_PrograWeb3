<%@ Page Language="C#" MasterPageFile="~/main/master/Cocinero.master" AutoEventWireup="true" CodeBehind="recetas.aspx.cs" Inherits="Tp__PrograWeb3.main.cocineros.recetas" %>

<%--
El cocinero puede crear recetas de cocina que luego son las que ofrecerá en los eventos. Para
crear una receta se deberá cargar la siguiente información:
­ nombre.
­ tiempo de cocción en minutos (numérico).
­ descripción y pasos de realización.
­ Ingredientes.
­ tipo (gourmet, diet, casera, etc.) Deberán utilizar un dropdownlist.
Todos los campos son obligatorios y se deben validar los tipos de datos en los casos que
corresponda.
Las recetas deberán asociadas al cocinero que las haya creado.--%>

<asp:Content ID="Content3" ContentPlaceHolderID="main" Runat="Server">
    <div class="col-md-12">
        <div class="text-center col-md-12">
            <h1>RECETAS</h1>
        </div>
        <form id="Form1" class="form" runat="server">
          <div class="form-group col-md-6">
            <label>Nombre:</label>
            <input type="text" class="form-control" runat="server" id="nombreId" placeholder="Ingrese nombre">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="nombreId" CssClass="has-error">
                <span class="help-block">Ingrese un nombre</span>
            </asp:RequiredFieldValidator>
          </div>

          <div class="form-group col-md-6">
            <label>Tiempo de cocción en minutos:</label>
            <input type="number" class="form-control" runat="server" id="tiempoId" min="1">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ControlToValidate="nombreId" CssClass="has-error">
                <span class="help-block">Ingrese el tiempo de cocción</span>
            </asp:RequiredFieldValidator>
          </div>

          <div class="form-group col-md-12">
            <label>Descripción y pasos de realición:</label>
            <textarea class="form-control" rows="5" id="descripcionId" placeholder="Ingrese Descripción" runat="server"></textarea>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ControlToValidate="descripcionId" CssClass="has-error">
                <span class="help-block">Ingrese una descripcion</span>
            </asp:RequiredFieldValidator>
          </div>            

          <div class="form-group col-md-12">
            <label>Ingredientes:</label>
            <textarea class="form-control" rows="5" id="ingredientesId" placeholder="Ingrese ingredientes" runat="server"></textarea>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ControlToValidate="ingredientesId" CssClass="has-error">
                <span class="help-block">Ingrese ingredientes</span>
            </asp:RequiredFieldValidator>

          </div>            

          <div class="form-group col-md-6">
            <label>Tipo:</label>
              <asp:DropDownList ID="tipoId" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True" Value="seleccione" >Seleccione</asp:ListItem>
                  <asp:ListItem Value="1">Gourmet</asp:ListItem>
                  <asp:ListItem Value="2">Diet</asp:ListItem>
                  <asp:ListItem Value="3">Casera</asp:ListItem>
                  <asp:ListItem Value="4">Vegetariana</asp:ListItem>

              </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" InitialValue="seleccione" runat="server" Display="Dynamic" ControlToValidate="tipoId" CssClass="has-error">
                <span class="help-block">Seleccione un tipo</span>
            </asp:RequiredFieldValidator>
          </div>

          <div class="form-group col-md-12">
            <asp:Button runat="server" id="saveButton" CssClass="btn btn-success pull-right" text="Guardar Receta" onclick="GuardarRecetaClick" />
          </div>
          <div class="form-group col-md-12">
            <asp:Label runat="server" CssClass="pull-right" id="StatusLabel" text="" />
          </div>

        </form>
    </div>
</asp:Content>
