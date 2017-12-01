using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de CategoriaDAL
/// </summary>
public class CategoriaDAL
{

    #region PATRON SINGLETON
    public static CategoriaDAL dalCategoria = null;
    private CategoriaDAL() { }
    public static CategoriaDAL getInstance()
    {
        if (dalCategoria == null)
        {
            dalCategoria = new CategoriaDAL();
        }
        return dalCategoria;
    }
    #endregion

    public List<CategoriaDTO> SelectAllCategoria()
    {

        List<CategoriaDTO> ListaCategoria = new List<CategoriaDTO>();
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        try
        {
            con = Conexion.getInstance().ConexionBD();
            cmd = new SqlCommand("sp_Categoria_SelectAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // Crear objetos de tipo Paciente
                CategoriaDTO objCategoria = new CategoriaDTO();
                objCategoria.Id = Convert.ToInt32(dr["id"].ToString());
                objCategoria.Nombre = dr["nombre"].ToString();


                // añadir a la lista de objetos
                ListaCategoria.Add(objCategoria);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
        return ListaCategoria;
    }


    public bool Actualizar(CategoriaDTO objCategoria)
    {
        bool ok = false;
        SqlConnection conexion = null;
        SqlCommand cmd = null;
        try
        {
            conexion = Conexion.getInstance().ConexionBD();
            cmd = new SqlCommand("sp_Categoria_Update", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objCategoria.Id);
            cmd.Parameters.AddWithValue("@nombre", objCategoria.Nombre);

            conexion.Open();

            cmd.ExecuteNonQuery();

            ok = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexion.Close();
        }
        return ok;
    }

    public bool Eliminar(int id)
    {
        SqlConnection conexion = null;
        SqlCommand cmd = null;
        bool ok = false;
        try
        {
            conexion = Conexion.getInstance().ConexionBD();
            cmd = new SqlCommand("sp_Categoria_Delete", conexion);
            cmd.Parameters.AddWithValue("@Original_id", id);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.ExecuteNonQuery();

            ok = true;

        }
        catch (Exception ex)
        {
            ok = false;
            throw ex;
        }
        finally
        {
            conexion.Close();
        }
        return ok;
    }



}
