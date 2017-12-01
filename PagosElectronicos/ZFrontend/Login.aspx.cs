using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad;
using Seguridad.BLL;

public partial class ZFrontend_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;

        //QUE RETORNE LA SESION SI ES DIFERENTE DE NULO
        if (SeguridadUtils.ThereAreUserInSession())
            Response.Redirect("~/ZBackend/PaginaDeInicio.aspx");
    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        MsgLabel.Visible = false;
        string nombreUsuario = txtUsuario.Text;
        string contrasena = SeguridadUtils.Hash(txtContrasena.Text);

        //PREGUNTA EN EL METODO SI EXISTE UN USUARIO CON ESE NOMBRE Y A SU VEZ COMPARA LAS CONTRASEñAS
        Usuario objUsuario = SeguridadUtils.IsUserValid(nombreUsuario, contrasena);

        if (objUsuario == null)
        {
            MsgLabel.Visible = true;
            return;
        }

        SeguridadUtils.SetUserInSession(objUsuario);
        Response.Redirect("~/ZBackend/PaginaDeInicio.aspx");

    }
}