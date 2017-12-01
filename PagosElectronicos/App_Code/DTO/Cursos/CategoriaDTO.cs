using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CategoriaDTO
/// </summary>
public class CategoriaDTO
{

    public int Id { get; set; }
    public string Nombre { get; set; }


    public CategoriaDTO() { }
    public CategoriaDTO(int id, string nombre)
    {
        this.Id = id;
        this.Nombre = nombre;

    }
}