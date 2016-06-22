<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="comentarios.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.comentarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyComensales" runat="server">
    

        <form id="Form1" runat="server">
            <div class="form-group-center col-md-12 ">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h4>Calificar <asp:Label ID="lblEventoNombre" runat="server" Text="Label"></asp:Label></h4>                    
                    </div>
                    <div class="panel-body">
                        <div class="col-md-8">
                            Comentario
                              <textarea class="form-control" rows="5"  id="comentario" placeholder="Ingrese Comentario" runat="server"></textarea>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="comentario" CssClass="has-error"> 
                            <span class="alert-danger">Ingrese un Comentario</span>
                        </asp:RequiredFieldValidator>
                        </div>
                         <div class="col-md-4">
                            Calificacion
                            <asp:ListBox  CssClass="lista form-control" ID="listCalificacion" runat="server" AutoPostBack="True" SelectionMode="Single" Rows="5">
                            </asp:ListBox>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="listCalificacion" CssClass="has-error">
                            <span class="alert-danger">Seleccione Calificacion</span>
                            </asp:RequiredFieldValidator>  
                         </div>
                        <asp:Button ID="btnSubmit" runat="server" Text="Calificar" CssClass="btn btn-success  pull-right" OnClick="btnSubmit_Click" />
                    </div>
                </div>
             </div>
        </form>
  
</asp:Content>

