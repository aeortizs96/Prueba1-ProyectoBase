using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormularioCategoria : System.Web.UI.Page
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
                Categoria objCategoria = CategoriaBLL.SelectById(Convert.ToInt32(id));
                if (objCategoria != null)
                {
                    txtNombre.Text = objCategoria.Nombre;
                    hdnId.Value = objCategoria.Id.ToString();
                }
            }

        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        SubirImagen.SaveAs(Server.MapPath("~/img/categoria/") + nombre + ".jpg");
        try
        {
            if (string.IsNullOrEmpty(hdnId.Value))
            {
                CategoriaBLL.Insert(nombre);

            }
            else
            {
                CategoriaBLL.Update(nombre, Convert.ToInt32(hdnId.Value));
            }
            Response.Redirect("~/ZBackend/ListaCategoria.aspx");
        }
        catch (Exception)
        {

        }
    }

    private void limpiarTextBoxs()
    {
        txtNombre.Text = string.Empty;
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        limpiarTextBoxs();
        Response.Redirect("~/ZBackend/ListaCategoria.aspx");
    }
}