using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ZBackend_DetalleCurso : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
    }

    protected void btnmatricula_Click(object sender, EventArgs e)
    {
        Response.Redirect("VerCatalogo.aspx");
    }

    protected void btnRegistroCertificado_Click(object sender, EventArgs e)
    {

        string id = Request.QueryString["id"];

        int registroCertificado = Convert.ToInt32(txtRestarRegistroCertificado.Text);
        CursoBLL.RestarRegistroCertificado(registroCertificado, Convert.ToInt32(id));


    }

    protected void btnRegistroGratis_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];

        int registroGratis = Convert.ToInt32(txtRestarRegistroGratis.Text);
        CursoBLL.RestarRegistroGratis(registroGratis, Convert.ToInt32(id));

    }

}