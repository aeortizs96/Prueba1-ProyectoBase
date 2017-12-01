<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="FormularioCursos.aspx.cs" Inherits="FormularioCurso" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <section class="content-header">
            <h1 style="text-align: center">REGISTRO DE CURSO</h1>
        </section>
        <asp:HiddenField runat="server" ID="hdnId" />

        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>NOMBRE DEL CURSO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombre" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server"
                                ControlToValidate="txtNombre"
                                ErrorMessage="Rellenar el campo de nomnbre de curso"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>CODIGO DEL CURSO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCodigo" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                ControlToValidate="txtCodigo"
                                ErrorMessage="Rellenar el campo de codigo de curso"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>


                        <div class="form-group">
                            <label>DESCRIPCION DEL CURSO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtdescripcionCurso" TextMode="MultiLine" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server"
                                ControlToValidate="txtdescripcionCurso"
                                ErrorMessage="Rellenar el campo de descripcion del curso"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>

                        <div class="form-group">
                            <label>FECHA INICIO DEL CURSO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtfechaInicio" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server"
                                ControlToValidate="txtfechaInicio"
                                ErrorMessage="Rellenar el campo de inicio del curso"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                            <cc3:CalendarExtender ID="CalendarExtender3" runat="server" DefaultView="Months" TargetControlID="txtfechaInicio" Format="dd/MM/yyyy"></cc3:CalendarExtender>
                        </div>

                        <div class="form-group">
                            <label>FECHA FIN DEL CURSO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtfechaFin" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                ControlToValidate="txtfechaFin"
                                ErrorMessage="Rellenar el campo de fecha fin del curso"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                            <cc3:CalendarExtender ID="CalendarExtender1" runat="server" DefaultView="Months" TargetControlID="txtfechaFin" Format="dd/MM/yyyy"></cc3:CalendarExtender>
                        </div>

                        <div class="form-group">
                            <label>MODALIDAD</label>
                        </div>

                        <div class="form-group">
                            <asp:DropDownList ID="txtmodalidad" runat="server" CssClass="form-control">
                                <asp:ListItem>Presencial</asp:ListItem>
                                <asp:ListItem>Semipresencial</asp:ListItem>
                                <asp:ListItem>Distancia</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>CUPO PARA INCRIPCION CON CERTIFICADO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtregistroCertificado" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                                ControlToValidate="txtregistroCertificado"
                                ErrorMessage="Rellenar el campo de certificaciones"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>CUPO PARA INCRIPCION GRATIS</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtregistroGratis" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                                ControlToValidate="txtregistroGratis"
                                ErrorMessage="Rellenar el campo de curso gratis"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DIRECCION</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtdireccion" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server"
                                ControlToValidate="txtdireccion"
                                ErrorMessage="Rellenar el direccion"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>NOMBRE DEL DOCENTE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtdocente" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server"
                                ControlToValidate="txtdocente"
                                ErrorMessage="Rellenar el campo de nombre de docente"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>DESCRIPCION DEL DOCENTE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtdescripcionDocente" TextMode="MultiLine" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                ControlToValidate="txtdescripcionDocente"
                                ErrorMessage="Rellenar el campo de descripcion del docente"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>HORA DE INICIO DEL CURSO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txthoraInicio" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                ControlToValidate="txthoraInicio"
                                ErrorMessage="Rellenar el campo de inicio del curso"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>

                        <div class="form-group">
                            <label>HORA DE FIN DEL CURSO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txthoraFin" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                ControlToValidate="txthoraFin"
                                ErrorMessage="Rellenar el campo de hora fin del curso"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>GRADO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="txtgrado" runat="server" CssClass="form-control">
                                <asp:ListItem>Pregrado</asp:ListItem>
                                <asp:ListItem>Postgrado</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>MONTO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtmonto" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server"
                                ControlToValidate="txtmonto"
                                ErrorMessage="Rellenar el campo de monto"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>


                        <div class="form-group">
                            <label>SUBIR IMAGEN</label>
                        </div>
                        <div class="form-group">
                            <asp:FileUpload ID="SubirImagen" runat="server" CssClass="btn" />
                        </div>




                    </div>
                </div>
            </div>
        </div>

        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Guardar" OnClick="btnGuardar_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CausesValidation="false" CssClass="btn btn-danger" Width="200px" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
            </table>
        </div>

    </div>

</asp:Content>

