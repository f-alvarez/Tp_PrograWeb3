<%@ Page Title="" Language="C#" MasterPageFile="~/main/master/Comensal.Master" AutoEventWireup="true" CodeBehind="reservar.aspx.cs" Inherits="Tp__PrograWeb3.main.comensales.reservar" %>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyComensales" runat ="server">
     <div class="col-md-12">
        <div class="text-center col-md-12">
            <h1>Reservar</h1>
        </div>
     </div>
        
         <div class="row">
	        <div class="col-md-12">
                 <div class="panel panel-primary">
                     <div class="panel-heading">
                        <h3 class="panel-title"><a href="#">Reservame!</a></h3>
                      </div>
			        <div class="panel-body">
				        <form id="gv" class="form-horizontal" runat="server"  >
                            <asp:GridView ID="gvRecetas" runat="server" CssClass="sinMarginBotton table table-bordered table-condensed" UseAccessibleHeader="True" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="nombre" HeaderText="Recetas" />
                                    <asp:BoundField DataField="tiempoDeCoccion" HeaderText="Tiempo de Coccion" />
                                    <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                                </Columns> 
                            </asp:GridView> 
                            <asp:GridView ID="gvListaEventosARecervar" runat="server" CssClass="sinMarginBotton table table-bordered table-condensed"  UseAccessibleHeader="True" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="cantidadComensales" HeaderText="Cantidad de comensales" />
                                    <asp:BoundField DataField="ubicacion" HeaderText="Ubicación" />
                                    <asp:BoundField DataField="foto" HeaderText="Foto" />
                                    <asp:BoundField DataField="precio" HeaderText="Precio" />
                                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                    <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                                    <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                                    <asp:HyperLinkField NavigateUrl="#" Text="Reservar" />
                                </Columns> 
                            </asp:GridView> 
                        </form>
			        </div>
		        </div>
            </div>
       </div>
</asp:Content>
