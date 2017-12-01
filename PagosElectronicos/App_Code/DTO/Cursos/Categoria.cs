using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Categoria
/// </summary>
public class Categoria
{
    public Categoria() {}
    public int Id { get; set; }
    public string Nombre { get; set; }

    public Categoria UnaCategoriaSeleccionada
    {
        get
        {
            return CategoriaBLL.SelectById(Id);
        }
    }
}