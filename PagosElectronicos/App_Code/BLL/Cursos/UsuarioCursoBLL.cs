using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de UsuarioCursoBLL
/// </summary>
public class UsuarioCursoBLL
{
    public UsuarioCursoBLL()
    { }
    public static List<UsuarioCurso> SelectAll()
    {

        List<UsuarioCurso> lista = new List<UsuarioCurso>();
        UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter adapter = new UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter();
        UsuarioCursoDS.sp_UsuarioCurso_SelectAllDataTable table = adapter.SelectAll();
        foreach (UsuarioCursoDS.sp_UsuarioCurso_SelectAllRow row in table)
        {
            lista.Add(rowToDTO(row));
        }
        return lista;
    }

    public static UsuarioCurso SelectByUserId(int id)
    {
        
        UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter adapter = new UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter();
        UsuarioCursoDS.sp_UsuarioCurso_SelectAllDataTable table = adapter.SelectByUserId(id);
        if (table.Rows.Count == 0)
        {
            return null;
        }
        return rowToDTO(table[0]);
    }

    public static void Insert(int idUsuario, int idCurso, string codigoGenerado)
    {
        UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter adapter = new UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter();
        adapter.Insert(idUsuario, idCurso, codigoGenerado);
    }
    //public static void Update(int idUsuario, int idCurso, string codigoGenerado, int id)
    //{
    //    UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter adapter = new UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter();
    //    adapter.Update(idUsuario, idCurso, codigoGenerado, id);
    //}
    public static void Delete(int id)
    {
        UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter adapter = new UsuarioCursoDSTableAdapters.sp_UsuarioCurso_SelectAllTableAdapter();
        adapter.Delete(id);
    }





    private static UsuarioCurso rowToDTO(UsuarioCursoDS.sp_UsuarioCurso_SelectAllRow row)
    {
        UsuarioCurso objUsuarioCurso = new UsuarioCurso();
        objUsuarioCurso.Id = row.id;
        objUsuarioCurso.IdUsuario = row.idUsuario;
        objUsuarioCurso.IdCurso = row.idCurso;
        objUsuarioCurso.CodigoGenerado = row.codigoGenerado;
        return objUsuarioCurso;


    }


}