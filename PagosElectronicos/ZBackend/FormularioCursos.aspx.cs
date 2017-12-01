using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormularioCurso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];
            if (id != null)
            {
                Curso objCurso = CursoBLL.SelectById(Convert.ToInt32(id));
                if (objCurso != null)
                {
                    txtNombre.Text = objCurso.Nombre;
                    txtdireccion.Text = objCurso.Direccion;
                    txtfechaInicio.Text = objCurso.FechaInicio;
                    txtfechaFin.Text = objCurso.FechaFin;
                    txthoraInicio.Text = objCurso.HoraInicio;
                    txthoraFin.Text = objCurso.HoraFin;
                    txtmonto.Text = objCurso.Monto.ToString();
                    txtdescripcionCurso.Text = objCurso.DescripcionCurso;
                    txtdocente.Text = objCurso.Docente;
                    txtdescripcionDocente.Text = objCurso.DescripcionDocente;
                    txtregistroCertificado.Text = objCurso.RegistroCertificado.ToString();
                    txtmodalidad.Text = objCurso.Modalidad;
                    txtgrado.Text = objCurso.Grado;
                    txtCodigo.Text = objCurso.Codigo;
                    txtregistroGratis.Text = objCurso.RegistroGratis.ToString();
                    hdnId.Value = objCurso.Id.ToString();


                }
            }
        }
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string direccion = txtdireccion.Text;
        string fechaInicio = txtfechaInicio.Text;
        string fechaFin = txtfechaFin.Text;
        string horaInicio = txthoraInicio.Text;
        string horaFin = txthoraFin.Text;
        int monto = Convert.ToInt32(txtmonto.Text);
        string descripcionCurso = txtdescripcionCurso.Text;
        string docente = txtdocente.Text;
        string descripcionDocente = txtdescripcionDocente.Text;
        int registroCertificado = Convert.ToInt32(txtregistroCertificado.Text);
        string modalidad = txtmodalidad.Text;
        string grado = txtgrado.SelectedValue;
        string codigo = txtCodigo.Text;
        int registroGratis = Convert.ToInt32(txtregistroGratis.Text);
        SubirImagen.SaveAs(Server.MapPath("~/img/cursos/") + nombre + ".jpg");

        try
        {
            if (string.IsNullOrEmpty(hdnId.Value))
            {
                CursoBLL.Insert(nombre, direccion, fechaInicio, fechaFin, horaInicio, horaFin, monto, descripcionCurso, docente, descripcionDocente, registroCertificado, modalidad, grado, codigo, registroGratis);

            }
            else
            {
                CursoBLL.Update(nombre, direccion, fechaInicio, fechaFin, horaInicio, horaFin, monto, descripcionCurso, docente, descripcionDocente, registroCertificado, modalidad, grado, codigo, registroGratis, Convert.ToInt32(hdnId.Value));
            }
            Response.Redirect("~/ZBackend/AbmCurso.aspx");
        }
        catch (Exception ex)
        {

        }
    }


    private void limpiarTextBoxs()
    {
        txtNombre.Text = string.Empty;
        txtdireccion.Text = string.Empty;
        txtfechaInicio.Text = string.Empty;
        txtfechaFin.Text = string.Empty;
        txthoraInicio.Text = string.Empty;
        txthoraFin.Text = string.Empty;
        txtmonto.Text = string.Empty;
        txtdescripcionCurso.Text = string.Empty;
        txtdescripcionDocente.Text = string.Empty;
        txtregistroCertificado.Text = string.Empty;
        txtmodalidad.Text = string.Empty;
        txtgrado.Text = string.Empty;
        txtregistroGratis.Text = string.Empty;
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        limpiarTextBoxs();
        Response.Redirect("~/ZBackend/AbmCurso.aspx");
    }
}