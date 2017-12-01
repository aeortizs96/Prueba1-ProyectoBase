using Seguridad;
using Seguridad.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ZBackend_PerfilUsuario : System.Web.UI.Page
{
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Usuario usuario = SeguridadUtils.GetUserInSession();

        CursoBLL.UsuarioSelectById(usuario.Id);


        id = usuario.Id.ToString();
        hdnId.Value = id;
        Response.Redirect("~/ZBackend/Default.aspx?ID=" + id);
    }

}