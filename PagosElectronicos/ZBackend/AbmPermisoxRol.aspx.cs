using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad;
using Seguridad.BLL;

public partial class ZBackend_AbmPermisoxRol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int id = Convert.ToInt32(btnEliminar.CommandArgument);
        PermisoRolBLL.Delete(id);
        grvPermisoRol.DataBind();
    }


    protected void grvPermisoRol_DataBound(object sender, EventArgs e)
    {
        Usuario usuario = SeguridadUtils.GetUserInSession();
        try
        {
            Dictionary<string, string> permisos = PermisoBLL.GetPermisosUsuario(usuario.Id);


            if (!permisos.ContainsKey("ELIMINAR_PERMISO_ROL"))
                grvPermisoRol.Columns[4].Visible = false;
          

            Dictionary<string, string> rol = RolBLL.GetPermisoRol(usuario.rolId);


            if (!rol.ContainsKey("ELIMINAR_PERMISO_ROL"))
                grvPermisoRol.Columns[6].Visible = false;
        
        }
        catch (Exception)
        {

        }
    }
}