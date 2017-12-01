using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CategoriaCursoBLL
/// </summary>
public class CategoriaCursoBLL
{
    public CategoriaCursoBLL()
    {
    }

    public static List<CategoriaCurso> SelectByIdCategoria(int id)
    {

        List<CategoriaCurso> listaCategoriaCursos = new List<CategoriaCurso>();

        CategoriaCursoDSTableAdapters.CategoriaCurso_SelectByIdCategoriaTableAdapter adapter = new CategoriaCursoDSTableAdapters.CategoriaCurso_SelectByIdCategoriaTableAdapter();
        CategoriaCursoDS.CategoriaCursoDataTable table = adapter.SelectByIdCategoria(id);
                
        foreach (CategoriaCursoDS.CategoriaCursoRow row in table)
        {
            listaCategoriaCursos.Add(rowToDto(row));
        }
        return listaCategoriaCursos;
    }





    private static CategoriaCurso rowToDto(CategoriaCursoDS.CategoriaCursoRow row)
    {
        CategoriaCurso objCategoriaCurso = new CategoriaCurso();

        objCategoriaCurso.Id = row.id;
        objCategoriaCurso.IdCategoria = row.idCategoria;
        objCategoriaCurso.IdCurso = row.idCurso;
        objCategoriaCurso.NombreCategoria = row.nombre;
        objCategoriaCurso.NombreCurso = row.nombre1;
        return objCategoriaCurso;

    }
}