using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CursoBLLS
/// </summary>
public class CursoBLLS
{
    #region "PATRON SINGLETON"
    private static CursoBLLS objCurso = null;
    private CursoBLLS() { }
    public static CursoBLLS getInstance()
    {
        if (objCurso == null)
        {
            objCurso = new CursoBLLS();
        }
        return objCurso;
    }
    #endregion


    public List<CursoDTO> SelectAllOrigen()
    {
        try
        {
            return CursoDAL.getInstance().SelectAllCurso();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public bool Actualizar(CursoDTO objCurso)
    {

        {
            try
            {
                return CursoDAL.getInstance().Actualizar(objCurso);
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
            return CursoDAL.getInstance().Eliminar(id);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}