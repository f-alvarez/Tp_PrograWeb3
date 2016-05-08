<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucEventosInicio.ascx.cs" Inherits="Tp__PrograWeb3.main.userControls.ucEventosInicio" %>

<div class="thumbnail">

    <asp:HyperLink ID="linkImgEvento" runat="server">
        <asp:Image ID="ImgEvento" CssClass="miniimgIndex" runat="server" />
    </asp:HyperLink>

    <div class="caption">                                
        <div>
            <h4><asp:HyperLink ID="linkNombreEvento" runat="server"></asp:HyperLink></h4>
        </div>
		<div>
            <h4>$<asp:Label ID="lblPrecio" runat="server"></asp:Label></h4>
		</div>
		<div>
            <asp:Label ID="lblPuntuacion" runat="server" CssClass="puntuacion"></asp:Label>
		</div>
    </div>
</div>