using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repositorios;
using AccesoADatos;

namespace Tp__PrograWeb3.main
{
    public partial class registracion : System.Web.UI.Page
    {
        UsuariosRepository UsuarioRepo = new UsuariosRepository(new PW3_TP_20161CEntities());

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void registrarUsuario(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                try
                {
                    Usuarios usuario = UsuarioRepo.getByMail(ucLabelTextoEmail.TextoTextBox);

                    if (usuario == null)
                    {
                        Usuarios nuevoUsuario = new Usuarios();
                        nuevoUsuario.Nombre = ucLabelTextoNombre.TextoTextBox;
                        nuevoUsuario.Password = ucLabelTextoPass.TextoTextBox;
                        nuevoUsuario.Email = ucLabelTextoEmail.TextoTextBox;
                        nuevoUsuario.FechaRegistracion = DateTime.Now;
                        nuevoUsuario.IdTipoUsuario = Byte.Parse(RadioButtonTipoUser.SelectedValue);
                        UsuarioRepo.add(nuevoUsuario);
                        StatusLabel.Text = "Estado: Usuario creado";
                        Response.Redirect("../anonimo/login.aspx");
                    }
                    else
                    {
                        StatusLabel.Text = "Estado: Ya existe ese usuario"; //FIX ME PLS
                    }
                        
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Estado: Tuvimos un error al registrarte" + ex.Message;

                }
            };

        }
    }
}