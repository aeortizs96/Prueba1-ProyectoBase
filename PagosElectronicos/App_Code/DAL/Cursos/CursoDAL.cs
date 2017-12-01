using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de CursoDAL
/// </summary>
public class CursoDAL
{

    #region PATRON SINGLETON
    public static CursoDAL dalCurso = null;
    private CursoDAL() { }
    public static CursoDAL getInstance()
    {
        if (dalCurso == null)
        {
            dalCurso = new CursoDAL();
        }
        return dalCurso;
    }
    #endregion

    public List<CursoDTO> SelectAllCurso()
    {

        List<CursoDTO> ListaCurso = new List<CursoDTO>();
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        try
        {
            con = Conexion.getInstance().ConexionBD();
            cmd = new SqlCommand("sp_Curso_SelectAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                // Crear objetos de tipo Paciente
                CursoDTO objCurso = new CursoDTO();
                objCurso.Id = Convert.ToInt32(dr["id"].ToString());
                objCurso.Nombre = dr["nombre"].ToString();
                objCurso.Direccion = dr["direccion"].ToString();
                objCurso.FechaInicio = dr["fechaInicio"].ToString();
                objCurso.FechaFin = dr["fechaFin"].ToString();
                objCurso.HoraInicio = dr["horaInicio"].ToString();
                objCurso.HoraFin = dr["horaFin"].ToString();
                objCurso.Monto = Convert.ToInt32(dr["monto"].ToString());
                objCurso.DescripcionCurso = dr["descripcionCurso"].ToString();
                objCurso.Docente = dr["docente"].ToString();
                objCurso.DescripcionDocente = dr["descripcionDocente"].ToString();
                objCurso.RegistroCertificado = Convert.ToInt32(dr["registroCertificado"].ToString());
                objCurso.Modalidad = dr["modalidad"].ToString();
                objCurso.Grado = dr["grado"].ToString();
                objCurso.Codigo = dr["codigo"].ToString();
                objCurso.RegistroGratis = Convert.ToInt32(dr["registroGratis"].ToString());


                // añadir a la lista de objetos
                ListaCurso.Add(objCurso);
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
        return ListaCurso;
    }


    public bool Actualizar(CursoDTO objCurso)
    {
        bool ok = false;
        SqlConnection conexion = null;
        SqlCommand cmd = null;
        try
        {
            conexion = Conexion.getInstance().ConexionBD();
            cmd = new SqlCommand("sp_Curso_Update", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objCurso.Id);
            cmd.Parameters.AddWithValue("@nombre", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@direccion", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@fechaInicio", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@fechaFin", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@horaInicio", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@horaFin", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@monto", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@descripcionCurso", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@descripcionDocente", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@registroCertificado", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@modalidad", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@grado", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@codigo", objCurso.Nombre);
            cmd.Parameters.AddWithValue("@registroGratis", objCurso.Nombre);

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
            cmd = new SqlCommand("sp_Curso_Delete", conexion);
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
