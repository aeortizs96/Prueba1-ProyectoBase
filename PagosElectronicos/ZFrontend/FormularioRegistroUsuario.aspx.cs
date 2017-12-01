using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad.BLL;
using Seguridad;

public partial class ZFrontend_FormularioRegistroUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
        }

    }

    private void limpiarTextBoxs()
    {
        txtNombre.Text = string.Empty;
        txtApellido.Text = string.Empty;
        txtNombreUsuario.Text = string.Empty;
        txtContrasena.Text = string.Empty;
        txtCorreo.Text = string.Empty;
        txtCI.Text = string.Empty;

    }




    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string nombreUsuario = txtNombreUsuario.Text;
        string contrasena = SeguridadUtils.Hash(txtContrasena.Text);
        string correo = txtCorreo.Text;
        string cI = txtCI.Text;
        string sexo = (ddlSexo.SelectedValue == "Femenino") ? "F" : "M";
        int rolPorDefecto = 3;
        try
        {
            if (string.IsNullOrEmpty(hdnId.Value))
            {
                UsuarioBLL.Insert(nombre, apellido, nombreUsuario, contrasena, correo, cI, sexo, rolPorDefecto);
            }
            else
            {
                Response.Redirect("~/ZFrontend/Login.aspx");
            }
            Response.Redirect("~/ZFrontend/Login.aspx");
        }
        catch (Exception)
        {

        }
    }




    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        limpiarTextBoxs();
        Response.Redirect("~/ZFrontend/PaginaDeInicioInvitado.aspx");
    }
}