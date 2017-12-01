using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ZBackend_ListaCategoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        }
    }

    [WebMethod]
    public static List<CategoriaDTO> SelectAllCategoria()
    {
        List<CategoriaDTO> Lista = null;
        try
        {
            Lista = CategoriaBLLS.getInstance().SelectAllOrigen();
        }
        catch (Exception ex)
        {
            Lista = new List<CategoriaDTO>();
        }
        return Lista;
    }

    [WebMethod]
    public static bool ActualizarDatosCategoria(String id, String nombre)
    {
        CategoriaDTO objCategoria = new CategoriaDTO()
        {
            Id = Convert.ToInt32(id),
            Nombre = nombre
        };

        bool ok = CategoriaBLLS.getInstance().Actualizar(objCategoria);
        return ok;
    }


    [WebMethod]
    public static bool EliminarDatosCategoria(String id)
    {
        Int32 idCategoria = Convert.ToInt32(id);

        bool ok = CategoriaBLLS.getInstance().Eliminar(idCategoria);

        return ok;
    }



}