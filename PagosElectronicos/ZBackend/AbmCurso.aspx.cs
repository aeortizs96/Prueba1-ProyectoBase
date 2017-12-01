using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad.BLL;
using Seguridad;


public partial class AbmCurso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int id = Convert.ToInt32(btnEliminar.CommandArgument);
        CursoBLL.Delete(id);
        grvCurso.DataBind();
    }
    protected void grvCurso_DataBound(object sender, EventArgs e)
    {
        Usuario usuario = SeguridadUtils.GetUserInSession();
        try
        {
            Dictionary<string, string> permisos = PermisoBLL.GetPermisosUsuario(usuario.Id);

            if (!permisos.ContainsKey("ACTUALIZAR_CURSO"))
                grvCurso.Columns[11].Visible = false;
            if (!permisos.ContainsKey("ELIMINAR_CURSO"))
                grvCurso.Columns[12].Visible = false;



            Dictionary<string, string> rol = RolBLL.GetPermisoRol(usuario.rolId);

            if (!rol.ContainsKey("ACTUALIZAR_CURSO"))
                grvCurso.Columns[13].Visible = false;
            if (!rol.ContainsKey("ELIMINAR_CURSO"))
                grvCurso.Columns[14].Visible = false;


        }
        catch (Exception ex)
        {

        }

    }

    protected void btnEliminar2_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int id = Convert.ToInt32(btnEliminar.CommandArgument);
        CursoBLL.Delete(id);
        grvCurso.DataBind();
    }
}