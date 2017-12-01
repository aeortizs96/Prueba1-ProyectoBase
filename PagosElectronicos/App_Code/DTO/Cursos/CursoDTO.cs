using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CursoDTO
/// </summary>
public class CursoDTO
{

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }

    public string FechaInicio { get; set; }
    public string FechaFin { get; set; }
    public string HoraInicio { get; set; }
    public string HoraFin { get; set; }
    public int Monto { get; set; }
    public string DescripcionCurso { get; set; }
    public string Modalidad { get; set; }
    public string Grado { get; set; }
    public string Codigo { get; set; }

    public string Docente { get; set; }
    public string DescripcionDocente { get; set; }
    public int RegistroCertificado { get; set; }
    public int RegistroGratis { get; set; }

    public CursoDTO() { }
    public CursoDTO(int id, string nombre, string direccion, string fechaInicio, string fechaFin, string horaInicio, string horaFin, int monto, string descripcionCurso, string docente, string descripcionDocente, int registroCertificado, string modalidad, string grado, string codigo, int registroGratis)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.FechaInicio = fechaInicio;
        this.FechaFin = fechaFin;
        this.HoraInicio = horaInicio;
        this.HoraFin = horaFin;
        this.Monto = monto;
        this.DescripcionCurso = descripcionCurso;
        this.Docente = docente;
        this.DescripcionDocente = descripcionDocente;
        this.RegistroCertificado = registroCertificado;
        this.Modalidad = modalidad;
        this.Grado = grado;
        this.Codigo = codigo;
        this.RegistroGratis = RegistroGratis;
    }



}