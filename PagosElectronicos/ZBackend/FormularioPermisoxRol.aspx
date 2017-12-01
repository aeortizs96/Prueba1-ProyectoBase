<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="FormularioPermisoxRol.aspx.cs" Inherits="ZBackend_FormularioPermisoxRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section class="content-header">
        <h1 style="text-align: center">AÑADIR PERMISOS AL ROL</h1>
    </section>
    <asp:HiddenField runat="server" ID="HiddenField1" />
    <div class="row">
        <div class="col-md-6">
            <div class="box box-primary">
                <div class="box-body">
                    <div class="form-group">
                        <label>ROL</label>
                    </div>
                    <div class="form-group">
                        <asp:DropDownList CssClass="form-control" ID="ddlRol" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Nombre" DataValueField="Id"></asp:DropDownList>
                        <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="Seguridad.BLL.RolBLL"></asp:ObjectDataSource>
                    </div>
                        <asp:HiddenField runat="server" ID="hdnId" />
                    <br />
                    <div class="form-group">
                        <label>PERMISOS</label>
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="REGISTRO CATEGORIA" CssClass="form-control" runat="server" ID="p1" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ACTUALIZAR CATEGORIA" runat="server" ID="p2" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ELIMINAR_CATEGORIA" runat="server" ID="p3" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="LISTA_CATEGORIA" runat="server" ID="p4" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="REGISTRO_CURSO" runat="server" ID="p5" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ACTUALIZAR_CURSO" runat="server" ID="p6" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ELIMINAR_CURSO" runat="server" ID="p7" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="LISTA_CURSO" runat="server" ID="p8" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="REGISTRO_PERMISO" runat="server" ID="p9" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ACTUALIZAR_PERMISO" runat="server" ID="p10" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ELIMINAR_PERMISO" runat="server" ID="p11" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="LISTA_PERMISO" runat="server" ID="p12" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="REGISTRO_ROL" runat="server" ID="p13" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ACTUALIZAR_ROL" runat="server" ID="p14" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ELIMINAR_ROL" runat="server" ID="p15" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="LISTA_ROL" runat="server" ID="p16" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="REGISTRO_USUARIO" runat="server" ID="p17" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ACTUALIZAR_USUARIO" runat="server" ID="p18" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ELIMINAR_USUARIO" runat="server" ID="p19" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="LISTA_USUARIO" runat="server" ID="p20" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="REGISTRO_PERMISO_ROL" runat="server" ID="p23" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="ELIMINAR_PERMISO_ROL" runat="server" ID="p24" CssClass="form-control" />
                    </div>
                    <div class="checkbox">
                        <asp:CheckBox Text="LISTA_PERMISO_ROL" runat="server" ID="p25" CssClass="form-control" />
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


    
</asp:Content>

