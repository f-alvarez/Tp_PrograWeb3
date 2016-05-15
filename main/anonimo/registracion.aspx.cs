using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Repositorios;

namespace Tp__PrograWeb3.main
{
    public partial class registracion : System.Web.UI.Page
    {
        UsuariosRepository UsuarioRepo = new UsuariosRepository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void registrarUsuario(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                try
                {
                    Usuario usuario = UsuarioRepo.getByMail(ucLabelTextoEmail.TextoTextBox);

                    if (usuario == null)
                    {
                        Usuario nuevoUsuario = new Usuario();
                        nuevoUsuario.nombre = ucLabelTextoNombre.TextoTextBox;
                        nuevoUsuario.pass = ucLabelTextoPass.TextoTextBox;
                        nuevoUsuario.mail = ucLabelTextoEmail.TextoTextBox;
                        nuevoUsuario.fechaIngreso = DateTime.Now.ToString();
                        nuevoUsuario.tipo = Int32.Parse(RadioButtonTipoUser.SelectedValue);
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