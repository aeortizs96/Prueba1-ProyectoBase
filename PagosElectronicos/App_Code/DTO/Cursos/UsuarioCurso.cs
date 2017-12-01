using Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de UsuarioCurso
/// </summary>
public class UsuarioCurso
{
    public UsuarioCurso() { }

    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public int IdCurso { get; set; }
    public string CodigoGenerado { get; set; }




    public UsuarioCurso UsuarioSeleccionado
    {
        get
        {
            return UsuarioCursoBLL.SelectByUserId(IdUsuario);
        }

    }

}