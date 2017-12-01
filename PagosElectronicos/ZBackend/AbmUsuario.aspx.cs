using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad.BLL;
using Seguridad;

public partial class AbmUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int id = Convert.ToInt32(btnEliminar.CommandArgument);
        UsuarioBLL.Delete(id);
        grvUsuario.DataBind();
    }
    protected void grvUsuario_DataBound(object sender, EventArgs e)
    {
        Usuario usuario = SeguridadUtils.GetUserInSession();
        try
        {
            Dictionary<string, string> permisos = PermisoBLL.GetPermisosUsuario(usuario.Id);

            if (!permisos.ContainsKey("ACTUALIZAR_USUARIO"))
                grvUsuario.Columns[7].Visible = false;
            if (!permisos.ContainsKey("ELIMINAR_USUARIO"))
                grvUsuario.Columns[8].Visible = false;


            Dictionary<string, string> rol = RolBLL.GetPermisoRol(usuario.rolId);

            if (!rol.ContainsKey("ACTUALIZAR_USUARIO"))
                grvUsuario.Columns[9].Visible = false;
            if (!rol.ContainsKey("ELIMINAR_USUARIO"))
                grvUsuario.Columns[10].Visible = false;

        }
        catch (Exception)
        {

        }
    }
}