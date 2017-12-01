using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad;
using Seguridad.BLL;

public partial class Backend : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // CONDICIONAL NEGACION DE LA CONDICION Y POR ELLO ME REDIRECCIONA A LOGIN
        if (!SeguridadUtils.ThereAreUserInSession())
            Response.Redirect("~/ZBackend/LoginBackend.aspx");

        if (IsPostBack)
            return;



        Usuario usuario = SeguridadUtils.GetUserInSession();




        try
        {

            Dictionary<string, string> rolPermisos = RolBLL.GetPermisoRol(usuario.rolId);
            Dictionary<string, string> permisos = PermisoBLL.GetPermisosUsuario(usuario.Id);


            //LISTAS DE PERMISOS POR ROL
            if (!rolPermisos.ContainsKey("LISTA_CATEGORIA"))
                abmCategoriaRol.Visible = false;
            if (!rolPermisos.ContainsKey("REGISTRO_CATEGORIA"))
                formCategoriaRol.Visible = false;

            if (!rolPermisos.ContainsKey("LISTA_PERMISO"))
                abmPermisoRol.Visible = false;

            if (!rolPermisos.ContainsKey("REGISTRO_PERMISO"))
                formPermisoRol.Visible = false;


            if (!rolPermisos.ContainsKey("LISTA_ROL"))
                abmRolRol.Visible = false;

            if (!rolPermisos.ContainsKey("REGISTRO_ROL"))
                formRolRol.Visible = false;

            if (!rolPermisos.ContainsKey("LISTA_CURSO"))
                abmCursoRol.Visible = false;

            if (!rolPermisos.ContainsKey("REGISTRO_CURSO"))
                formCursoRol.Visible = false;


            if (!rolPermisos.ContainsKey("LISTA_USUARIO"))
                abmUsuarioRol.Visible = false;

            if (!rolPermisos.ContainsKey("REGISTRO_USUARIO"))
                formUsuarioRol.Visible = false;

            if (!rolPermisos.ContainsKey("LISTA_PERMISO_ROL"))
                abmRolesPermisoRol.Visible = false;

            if (!rolPermisos.ContainsKey("REGISTRO_PERMISO_ROL"))
                formPermiRolRol.Visible = false;

            

            //LISTA DE PERMISOS POR USUARIO

            if (!permisos.ContainsKey("LISTA_CATEGORIA"))
                abmCategoria.Visible = false;

            if (!permisos.ContainsKey("REGISTRO_CATEGORIA"))
                formCategoria.Visible = false;

            if (!permisos.ContainsKey("LISTA_PERMISO"))
                abmPermiso.Visible = false;

            if (!permisos.ContainsKey("REGISTRO_PERMISO"))
                formPermiso.Visible = false;

            if (!permisos.ContainsKey("LISTA_ROL"))
                abmRol.Visible = false;

            if (!permisos.ContainsKey("REGISTRO_ROL"))
                formRol.Visible = false;

            if (!permisos.ContainsKey("LISTA_CURSO"))
                abmCurso.Visible = false;

            if (!permisos.ContainsKey("REGISTRO_CURSO"))
                formCurso.Visible = false;

            if (!permisos.ContainsKey("LISTA_USUARIO"))
                abmUsuario.Visible = false;

            if (!permisos.ContainsKey("REGISTRO_USUARIO"))
                formUsuario.Visible = false;

            if (!permisos.ContainsKey("REGISTRO_PERMISO_ROL"))
                formPermiRol.Visible = false;

            //ARREGLAR

            //if (!rolPermisos.ContainsKey("REGISTRO_PERMISO_ROL"))
            //    abmRolesPermiso.Visible = false;



        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.ToString());
        }


    }

    protected void BtnLogout_Click(object sender, EventArgs e)
    {
        SeguridadUtils.Logout();
        Response.Redirect("~/ZFrontend/PaginaDeInicioInvitado.aspx");
    }




}
