<%@ Page Title="" Language="C#" MasterPageFile="~/ZFrontend/Frontend.master" AutoEventWireup="true" CodeFile="FormularioRegistroUsuario.aspx.cs" Inherits="ZFrontend_FormularioRegistroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1 style="text-align: center">REGISTRO DE USUARIO</h1>
    </section>
    <section class="content">
        <asp:HiddenField runat="server" ID="hdnId" />



        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DOCUMENTO DE IDENTIDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCI" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                ControlToValidate="txtCI"
                                ErrorMessage="Rellenar el campo de CI"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>NOMBRES</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombre" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                ControlToValidate="txtNombre"
                                ErrorMessage="Rellenar el campo de Nombre"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>APELLIDOS</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtApellido" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                ControlToValidate="txtApellido"
                                ErrorMessage="Rellenar el campo de Apellido"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>SEXO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                                <asp:ListItem>Masculino</asp:ListItem>
                                <asp:ListItem>Femenino</asp:ListItem>
                            </asp:DropDownList>
                        </div>


                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">

                        <div class="form-group">
                            <label>USUARIO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombreUsuario" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                ControlToValidate="txtNombreUsuario"
                                ErrorMessage="Rellenar el campo de Usuario"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>CONTRASEÑA</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtContrasena" runat="server" Text="" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                ControlToValidate="txtContrasena"
                                ErrorMessage="Rellenar el campo de Contraseña"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label>CORREO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtCorreo" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                                ControlToValidate="txtCorreo"
                                ErrorMessage="Rellenar el campo de Correo"
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div align="center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary" Width="200px" Text="Registrar" OnClick="btnGuardar_Click" />
                    </td>

                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>

                    <td>
                        <asp:Button ID="btnCancelarrojo" runat="server" CssClass="btn btn-danger" CausesValidation="false" Width="200px" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </td>
                </tr>
            </table>
        </div>




    </section>



</asp:Content>

