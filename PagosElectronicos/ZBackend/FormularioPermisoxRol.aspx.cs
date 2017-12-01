using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad;
using Seguridad.BLL;


public partial class ZBackend_FormularioPermisoxRol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }




    protected void btnGuardar_Click(object sender, EventArgs e)
    {

        //int idLibro = Convert.ToInt32(cblibro.SelectedValue);
        int idRol = Convert.ToInt32(ddlRol.SelectedValue.ToString());
        int permiso1 = 1;
        int permiso2 = 2;
        int permiso3 = 3;
        int permiso4 = 4;
        int permiso5 = 5;
        int permiso6 = 6;
        int permiso7 = 7;
        int permiso8 = 8;
        int permiso9 = 9;
        int permiso10 = 10;
        int permiso11 = 11;
        int permiso12 = 12;
        int permiso13 = 13;
        int permiso14 = 14;
        int permiso15 = 15;
        int permiso16 = 16;
        int permiso17 = 17;
        int permiso18 = 18;
        int permiso19 = 19;
        int permiso20 = 20;
        int permiso23 = 23;
        int permiso24 = 24;
        int permiso25 = 25;
      


        try
        {
            if (string.IsNullOrEmpty(hdnId.Value))
            {
                if (p1.Checked)
                {
                    PermisoRolBLL.Insert(permiso1, idRol);
                }
                if (p2.Checked)
                {
                    PermisoRolBLL.Insert(permiso2, idRol);
                }
                if (p3.Checked)
                {
                    PermisoRolBLL.Insert(permiso3, idRol);

                }
                if (p4.Checked)
                {
                    PermisoRolBLL.Insert(permiso4, idRol);

                }
                if (p5.Checked)
                {
                    PermisoRolBLL.Insert(permiso5, idRol);
                }
                if (p6.Checked)
                {
                    PermisoRolBLL.Insert(permiso6, idRol);
                }
                if (p7.Checked)
                {
                    PermisoRolBLL.Insert(permiso7, idRol);
                }
                if (p8.Checked)
                {
                    PermisoRolBLL.Insert(permiso8, idRol);
                }
                if (p9.Checked)
                {
                    PermisoRolBLL.Insert(permiso9, idRol);
                }
                if (p10.Checked)
                {
                    PermisoRolBLL.Insert(permiso10, idRol);

                }
                if (p11.Checked)
                {
                    PermisoRolBLL.Insert(permiso11, idRol);

                }
                if (p12.Checked)
                {
                    PermisoRolBLL.Insert(permiso12, idRol);
                }
                if (p13.Checked)
                {
                    PermisoRolBLL.Insert(permiso13, idRol);

                }
                if (p14.Checked)
                {
                    PermisoRolBLL.Insert(permiso14, idRol);

                }
                if (p15.Checked)
                {
                    PermisoRolBLL.Insert(permiso15, idRol);
                }
                if (p16.Checked)
                {
                    PermisoRolBLL.Insert(permiso16, idRol);

                }
                if (p17.Checked)
                {
                    PermisoRolBLL.Insert(permiso17, idRol);
                }
                if (p18.Checked)
                {
                    PermisoRolBLL.Insert(permiso18, idRol);

                }
                if (p19.Checked)
                {
                    PermisoRolBLL.Insert(permiso19, idRol);

                }
                if (p20.Checked)
                {
                    PermisoRolBLL.Insert(permiso20, idRol);
                }
                if (p23.Checked)
                {
                    PermisoRolBLL.Insert(permiso23, idRol);
                }
                if (p24.Checked)
                {
                    PermisoRolBLL.Insert(permiso24, idRol);
                }
                if (p25.Checked)
                {
                    PermisoRolBLL.Insert(permiso25, idRol);
                }
               
            }


            Response.Redirect("~/ZBackend/AbmPermisoxRol.aspx");
        }
        catch (Exception)
        {


        }
    }

  

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("~/ZBackend/AbmPermisoxRol.aspx");
    }
}