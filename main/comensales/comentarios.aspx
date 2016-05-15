<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="comentarios.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.comentarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyComensales" runat="server">

    <div class="text-center">
        <h1>PUNTUAR Y COMENTAR</h1>
    </div>
    <div class="ContenedorFormulario">

        <form id="Form1" class="form-horizontal" runat="server">
            <div class="form-group-center col-md-12 ">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4>Puntuaci&oacute;n</h4>
                    </div>

                    <div class="panel-body">
                        <asp:ListBox ID="listPuntu" runat="server" AutoPostBack="True" SelectionMode="Single" CssClass="list-group-item" Rows="5"></asp:ListBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="listPuntu" CssClass="has-error"><span class="alert-danger">Seleccione un Puntaje</span></asp:RequiredFieldValidator>
                    </div>
                    

                </div>
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4>Comentario</h4>
                    </div>


                    <div class="panel-body">
                        <textarea class="form-control" rows="5" id="comentId" placeholder="Ingrese Comentario" runat="server">

            </textarea>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="comentId"> <span class="alert-danger">Ingrese un Comentario</span></asp:RequiredFieldValidator>
                    </div>
                </div>



                <asp:Button ID="btnSubmit" runat="server" Text="Calificar" CssClass="btn btn-success  pull-right" OnClick="btnSubmit_Click" />
             

            </div>

        </form>
    </div>
</asp:Content>

