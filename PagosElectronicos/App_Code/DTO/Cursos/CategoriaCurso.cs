using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CategoriaCurso
/// </summary>
public class CategoriaCurso
{
    public CategoriaCurso(){}

    
    public int Id { get; set; }
    public int IdCategoria { get; set; }
    public int IdCurso { get; set; }
    public string NombreCategoria { get; set; }
    public string NombreCurso { get; set; }

    public Curso CursoSeleccionado
    {
        get
        {
            return CursoBLL.SelectById(IdCurso);
        }
    }

}