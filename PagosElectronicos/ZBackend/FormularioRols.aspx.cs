using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad;
using Seguridad.BLL;

public partial class FormularioRol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //para reconocer un parametro de la url
            string id = Request.QueryString["id"];
            //porque lo convierte en string si el ID inicialmente esta en int 
            //y luego nuevamente lo vuelve a recibir como int
            if (id != null)
            {
                Rol objRol = RolBLL.SelectById(Convert.ToInt32(id));
                if (objRol != null)
                {
                    txtNombre.Text = objRol.Nombre;
                    txtDescripcion.Text = objRol.Descripcion;
                    hdnId.Value = objRol.Id.ToString();
                }
            }

        }

    }


    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string descripcion = txtDescripcion.Text;
        try
        {
            if (string.IsNullOrEmpty(hdnId.Value))
            {
                RolBLL.Insert(nombre, descripcion);

            }
            else
            {
                RolBLL.Update(nombre, descripcion, Convert.ToInt32(hdnId.Value));
            }
            Response.Redirect("~/ZBackend/AbmRol.aspx");
        }
        catch (Exception)
        {

        }
    }

    private void limpiarTextBoxs()
    {

        txtNombre.Text = string.Empty;
        txtDescripcion.Text = string.Empty;
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        limpiarTextBoxs();
        Response.Redirect("~/ZBackend/AbmPermiso.aspx");
    }
}