using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CursoBLL
/// </summary>
public class CursoBLL
{
    public CursoBLL() { }
    public static List<Curso> SelectAll()
    {
        List<Curso> listaCursos = new List<Curso>();
        CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter adapter = new CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter();
        CursoDS.sp_Curso_SelectAllDataTable table = adapter.SelectAll();
        foreach (CursoDS.sp_Curso_SelectAllRow row in table)
        {
            listaCursos.Add(rowToDTO(row));
        }
        return listaCursos;
    }

    public static List<Curso> SelectAllFecha()
    {
        List<Curso> listaCursos = new List<Curso>();
        CursoDSTableAdapters.sp_Curso_SelectAllByFechaTableAdapter adapter = new CursoDSTableAdapters.sp_Curso_SelectAllByFechaTableAdapter();
        CursoDS.sp_Curso_SelectAllByFechaDataTable table = adapter.SelectAllFecha();
        foreach (CursoDS.sp_Curso_SelectAllByFechaRow row in table)
        {
            listaCursos.Add(rowToDTO2(row));
        }
        return listaCursos;
    }

    private static Curso rowToDTO2(CursoDS.sp_Curso_SelectAllByFechaRow row)
    {
        Curso objCurso = new Curso();
        objCurso.Id = row.id;
        objCurso.Nombre = row.nombre;
        objCurso.Direccion = row.direccion;
        objCurso.FechaInicio = row.fechaInicio.ToString();
        objCurso.FechaFin = row.fechaFin.ToString();
        objCurso.HoraInicio = row.horaInicio;
        objCurso.HoraFin = row.horaFin;
        objCurso.Monto = row.monto;
        objCurso.DescripcionCurso = row.descripcionCurso;
        objCurso.Docente = row.docente;
        objCurso.DescripcionDocente = row.descripcionDocente;
        objCurso.RegistroCertificado = row.registroCertificado;
        objCurso.Modalidad = row.modalidad;
        objCurso.Grado = row.grado;
        objCurso.Codigo = row.codigo;
        objCurso.RegistroGratis = row.registroGratis;
        return objCurso;
    }

    public static Curso SelectById(int id)
    {
        CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter adapter = new CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter();
        CursoDS.sp_Curso_SelectAllDataTable table = adapter.SelectById(id);
        if (table.Rows.Count == 0)
        {
            return null;
        }
        return rowToDTO(table[0]);
    }

    public static Curso UsuarioSelectById(int id)
    {
        CursoDSTableAdapters.sp_UsuarioCurso_SelectByUserIdTableAdapter adapter = new CursoDSTableAdapters.sp_UsuarioCurso_SelectByUserIdTableAdapter();
        CursoDS.sp_UsuarioCurso_SelectByUserIdDataTable table = adapter.sp_UsuarioCurso_SelectById(id);
        if (table.Rows.Count == 0)
        {
            return null;
        }
        return rowToDTO2(table[0]);
    }

   
    public static void RestarRegistroCertificado(int registroCertificado, int id)
    {
        CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter adapter = new CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter();
        adapter.RestaRegistroCertificado(registroCertificado, id);
    }

    public static void RestarRegistroGratis(int registroGratis, int id)
    {
        CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter adapter = new CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter();
        adapter.RestaRegistroGratis(registroGratis, id);
    }

    public static void Insert(string nombre, string direccion, string fechaInicio, string fechaFin, string horaInicio, string horaFin, int monto, string descripcionCurso, string docente, string descripcionDocente, int registroCertificado, string modalidad, string grado, string codigo, int registroGratis)
    {
        CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter adapter = new CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter();
        adapter.Insert(nombre, direccion, fechaInicio, fechaFin, horaInicio, horaFin, monto, descripcionCurso, docente, descripcionDocente, registroCertificado, modalidad, grado, codigo, registroGratis);
    }

    public static void Update(string nombre, string direccion, string fechaInicio, string fechaFin, string horaInicio, string horaFin, int monto, string descripcionCurso, string docente, string descripcionDocente, int registroCertificado, string modalidad, string grado, string codigo, int registroGratis, int id)
    {
        CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter adapter = new CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter();
        adapter.Update(nombre, direccion, fechaInicio, fechaFin, horaInicio, horaFin, monto, descripcionCurso, docente, descripcionDocente, registroCertificado, modalidad, grado, codigo, registroGratis, id);
    }

    public static void Delete(int id)
    {
        CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter adapter = new CursoDSTableAdapters.sp_Curso_SelectAllTableAdapter();
        adapter.Delete(id);
    }

    private static Curso rowToDTO(CursoDS.sp_Curso_SelectAllRow row)
    {

        Curso objCurso = new Curso();
        objCurso.Id = row.id;
        objCurso.Nombre = row.nombre;
        objCurso.Direccion = row.direccion;
        objCurso.FechaInicio = row.fechaInicio.ToString();
        objCurso.FechaFin = row.fechaFin.ToString();
        objCurso.HoraInicio = row.horaInicio;
        objCurso.HoraFin = row.horaFin;
        objCurso.Monto = row.monto;
        objCurso.DescripcionCurso = row.descripcionCurso;
        objCurso.Docente = row.docente;
        objCurso.DescripcionDocente = row.descripcionDocente;
        objCurso.RegistroCertificado = row.registroCertificado;
        objCurso.Modalidad = row.modalidad;
        objCurso.Grado = row.grado;
        objCurso.Codigo = row.codigo;
        objCurso.RegistroGratis = row.registroGratis;
        return objCurso;
    }

    private static Curso rowToDTO2(CursoDS.sp_UsuarioCurso_SelectByUserIdRow row)
    {
        Curso objCurso = new Curso();

        objCurso.Nombre = row.nombre;
        objCurso.Direccion = row.direccion;
        objCurso.FechaInicio = row.fechaInicio.ToString();
        objCurso.FechaFin = row.fechaFin.ToString();
        objCurso.HoraInicio = row.horaInicio;
        objCurso.HoraFin = row.horaFin;
        objCurso.Monto = row.monto;
        objCurso.DescripcionCurso = row.descripcionCurso;
        objCurso.Docente = row.docente;
        objCurso.DescripcionDocente = row.descripcionDocente;
        objCurso.RegistroCertificado = row.registroCertificado;
        objCurso.Modalidad = row.modalidad;
        objCurso.Grado = row.grado;
        objCurso.Codigo = row.codigo;
        objCurso.RegistroGratis = row.registroGratis;
        return objCurso;
    }

}