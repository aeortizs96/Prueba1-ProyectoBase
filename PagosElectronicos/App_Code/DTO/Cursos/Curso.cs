using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Curso
/// </summary>
public class Curso
{
    public Curso() { }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string FechaInicio { get; set; }
    public string FechaFin { get; set; }
    public string HoraInicio { get; set; }
    public string HoraFin { get; set; }
    public int Monto { get; set; }
    public string DescripcionCurso { get; set; }
    public string Docente { get; set; }
    public string DescripcionDocente { get; set; }
    public int RegistroCertificado { get; set; }
    public string Modalidad { get; set; }
    public string Grado { get; set; }

    public string Codigo { get; set; }

    public int RegistroGratis { get; set; }
    public Curso CursoSeleccionado
    {
        get
        {
            return CursoBLL.SelectById(Id);
        }
    }
}