using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ZBackend_ListaCurso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        }
    }

    [WebMethod]
    public static List<CursoDTO> SelectAllCurso()
    {
        List<CursoDTO> Lista = null;
        try
        {
            Lista = CursoBLLS.getInstance().SelectAllOrigen();
        }
        catch (Exception ex)
        {
            Lista = new List<CursoDTO>();
        }
        return Lista;
    }

    [WebMethod]
    public static bool ActualizarDatosCurso(String id, String nombre, String direccion, string fechaInicio, string fechaFin, String horaInicio, String horaFin, int monto, String descripcionCurso, String docente, String descripcionDocente, int registroCertificado, String modalidad, String grado, String codigo, int registroGratis)
    {


        CursoDTO objCurso = new CursoDTO()

        {
            Id = Convert.ToInt32(id),
            Nombre = nombre,
            Direccion = direccion,
            FechaInicio = fechaInicio,
            FechaFin = fechaFin,
            HoraInicio = horaInicio,
            HoraFin = horaFin,
            Monto = monto,
            DescripcionCurso = descripcionCurso,//CASTEAR
            Docente = docente,
            DescripcionDocente = descripcionDocente,
            RegistroCertificado = registroCertificado,
            Modalidad = modalidad,
            Grado = grado,
            Codigo = codigo,
            RegistroGratis = registroGratis,
        };

        bool ok = CursoBLLS.getInstance().Actualizar(objCurso);
        return ok;
    }


    [WebMethod]
    public static bool EliminarDatosCurso(String id)
    {
        Int32 idCurso = Convert.ToInt32(id);

        bool ok = CursoBLLS.getInstance().Eliminar(idCurso);

        return ok;
    }



}