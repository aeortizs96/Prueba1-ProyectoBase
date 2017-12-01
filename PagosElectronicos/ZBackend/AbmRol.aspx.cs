using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad.BLL;
using Seguridad;

public partial class AbmRol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int id = Convert.ToInt32(btnEliminar.CommandArgument);
        RolBLL.Delete(id);
        grvRol.DataBind();

      


    }

    protected void grvRol_DataBound(object sender, EventArgs e)
    {
        Usuario usuario = SeguridadUtils.GetUserInSession();
        try
        {
            Dictionary<string, string> permisos = PermisoBLL.GetPermisosUsuario(usuario.Id);

            if (!permisos.ContainsKey("ACTUALIZAR_ROL"))
                grvRol.Columns[3].Visible = false;
            if (!permisos.ContainsKey("ELIMINAR_ROL"))
                grvRol.Columns[4].Visible = false;
          


            Dictionary<string, string> rol = RolBLL.GetPermisoRol(usuario.rolId);

            if (!rol.ContainsKey("ACTUALIZAR_ROL"))
                grvRol.Columns[5].Visible = false;
            if (!rol.ContainsKey("ELIMINAR_ROL"))
                grvRol.Columns[6].Visible = false;
         




        }
        catch (Exception)
        {

        }
    }
}