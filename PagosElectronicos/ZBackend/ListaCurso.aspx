<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="ListaCurso.aspx.cs" Inherits="ZBackend_ListaCurso" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- Datatable Part -->

    <div class="row">
        <div class="col-xs-12">
            <div class="box box-primary">
                <div class="box-header">
                    <h3 class="box-title">Lista de Curso</h3>
                </div>
                <div class="box-body table-responsive">
                    <table id="tbl_pacientes" class="table table-bordered table-hover">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Nombres</th>
                                <th>Direccion</th>
                                <th>Fecha Inicio</th>
                                <th>Fecha Fin</th>
                                <th>Hora Inicio</th>
                                <th>Hora Fin</th>
                                <th>Monto</th>
                                <th>Descripcion Curso</th>
                                <th>Docente</th>
                                <th>Descripcion Docente</th>
                                <th>Registro</th>
                                <th>Modalidad</th>
                                <th>Grado</th>
                                <th>Codigo</th>
                                <th>Acciones</th>
                            </tr>
                        </thead>
                        <tbody id="tbl_body_table">
                            <!-- DATA POR MEDIO DE AJAX-->
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <!-- End Datatable -->
    <div class="modal fade" id="imodal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">Actualizar registro</h4>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label>NOMBRE CURSO</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtnombreCurso" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>



                <div class="modal-body">
                    <div class="form-group">
                        <label>DIRECCION</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtdireccion" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>


                <div class="modal-body">
                    <div class="form-group">
                        <label>FECHA INICIO</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtfechaInicio" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>



                <div class="modal-body">
                    <div class="form-group">
                        <label>FECHA FIN</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtfechaFin" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>


                <div class="modal-body">
                    <div class="form-group">
                        <label>HORA INICIO</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txthraInicio" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>



                <div class="modal-body">
                    <div class="form-group">
                        <label>HORA FIN</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txthoraFin" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>


                <div class="modal-body">
                    <div class="form-group">
                        <label>MONTO</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtmonto" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>


                <div class="modal-body">
                    <div class="form-group">
                        <label>DESCRIPCION CURSO</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtdescripcionCurso" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>

                <div class="modal-body">
                    <div class="form-group">
                        <label>DOCENTE</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtdocente" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>


                <div class="modal-body">
                    <div class="form-group">
                        <label>DESCRIPCION DOCENTE</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtdescripcionDocente" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>


                <div class="modal-body">
                    <div class="form-group">
                        <label>CANTIDAD DE PERSONAS</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtcantidadPersonas" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>

                <div class="modal-body">
                    <div class="form-group">
                        <label>MODALIDAD</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtmodalidad" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label>GRADO</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtgrado" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label>CODIGO</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtcodigo" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" id="btnactualizar">Actualizar</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="../js/CursoLista.js" type="text/javascript">
    
    </script>

</asp:Content>


