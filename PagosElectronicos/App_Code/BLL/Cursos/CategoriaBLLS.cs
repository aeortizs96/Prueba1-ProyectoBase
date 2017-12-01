using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CategoriaBLLS
/// </summary>
public class CategoriaBLLS
{
    #region "PATRON SINGLETON"
    private static CategoriaBLLS objCategoria = null;
    private CategoriaBLLS() { }
    public static CategoriaBLLS getInstance()
    {
        if (objCategoria == null)
        {
            objCategoria = new CategoriaBLLS();
        }
        return objCategoria;
    }
    #endregion


    public List<CategoriaDTO> SelectAllOrigen()
    {
        try
        {
            return CategoriaDAL.getInstance().SelectAllCategoria();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public bool Actualizar(CategoriaDTO objCategoria)
    {

        {
            try
            {
                return CategoriaDAL.getInstance().Actualizar(objCategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }

    public bool Eliminar(int id)
    {
        try
        {
            return CategoriaDAL.getInstance().Eliminar(id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}