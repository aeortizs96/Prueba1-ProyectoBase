using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CategoriaBLL
/// </summary>
public class CategoriaBLL
{
    public CategoriaBLL() { }

    




    public static List<Categoria> SelectAll()
    {

        List<Categoria> listaCategorias = new List<Categoria>();
        CategoriaDSTableAdapters.tblCategoriaTableAdapter adapter = new CategoriaDSTableAdapters.tblCategoriaTableAdapter();
        CategoriaDS.tblCategoriaDataTable table = adapter.SelectAll();
        foreach (CategoriaDS.tblCategoriaRow row in table)
        {
            listaCategorias.Add(rowToDTO(row));
        }
        return listaCategorias;
    }


    public static Categoria SelectById(int id)
    {
        CategoriaDSTableAdapters.tblCategoriaTableAdapter adapter = new CategoriaDSTableAdapters.tblCategoriaTableAdapter();
        CategoriaDS.tblCategoriaDataTable table = adapter.SelectById(id);
        if (table.Rows.Count == 0)
        {
            return null;
        }
        return rowToDTO(table[0]);
    }

    public static void Insert(string nombre)
    {
        CategoriaDSTableAdapters.tblCategoriaTableAdapter adapter = new CategoriaDSTableAdapters.tblCategoriaTableAdapter();
        adapter.Insert(nombre);
    }
    public static void Update(string nombre, int id)
    {
        CategoriaDSTableAdapters.tblCategoriaTableAdapter adapter = new CategoriaDSTableAdapters.tblCategoriaTableAdapter();
        adapter.Update(nombre, id);
    }
    public static void Delete(int id)
    {
        CategoriaDSTableAdapters.tblCategoriaTableAdapter adapter = new CategoriaDSTableAdapters.tblCategoriaTableAdapter();
        adapter.Delete(id);
    }


    private static Categoria rowToDTO(CategoriaDS.tblCategoriaRow row)
    {
        Categoria objCategoria = new Categoria();
        objCategoria.Id = row.id;
        objCategoria.Nombre = row.nombre;
        return objCategoria;
    }
}