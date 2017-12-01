using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad;
using Seguridad.BLL;
public partial class ZFrontend_DetalleCurso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;

    }






    protected void btnmatriculaSinRegistro_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx"); // cambiar
    }

    protected void btnRegistroCertificado_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void btnRegistroGratis_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }


}