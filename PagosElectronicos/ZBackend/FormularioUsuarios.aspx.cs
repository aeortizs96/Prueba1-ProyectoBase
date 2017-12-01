using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad.BLL;
using Seguridad;

public partial class FormularioUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            limpiarTextBoxs();
            //para reconocer un parametro de la url
            string id = Request.QueryString["id"];
            //porque lo convierte en string si el ID inicialmente esta en int 
            //y luego nuevamente lo vuelve a recibir como int

            if (id != null)
            {
                Usuario objUsuario = UsuarioBLL.SelectById(Convert.ToInt32(id));
                if (objUsuario != null)
                {
                    txtNombre.Text = objUsuario.Nombre;
                    txtApellido.Text = objUsuario.Apellido;
                    txtNombreUsuario.Text = objUsuario.NombreUsuario;
                    txtContrasena.Text = objUsuario.Contrasena;
                    txtCorreo.Text = objUsuario.Correo;
                    txtCI.Text = objUsuario.CI;
                    hdnId.Value = objUsuario.Id.ToString();
                }
            }

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
        int rolId = Convert.ToInt32(ddlRol.SelectedValue.ToString());
        
        try
        {
            if (string.IsNullOrEmpty(hdnId.Value))
            {
                UsuarioBLL.Insert(nombre, apellido, nombreUsuario, contrasena, correo, cI, sexo, rolId);

            }
            else
            {
                UsuarioBLL.Update(nombre, apellido, nombreUsuario, contrasena, correo, cI, sexo, rolId, Convert.ToInt32(hdnId.Value));
            }
            Response.Redirect("~/ZBackend/AbmUsuario.aspx");
        }
        catch (Exception)
        {

        }
    }




    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        limpiarTextBoxs();
        Response.Redirect("~/ZBackend/AbmUsuario.aspx");
    }
}