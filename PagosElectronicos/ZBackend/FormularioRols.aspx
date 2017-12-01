<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="FormularioRols.aspx.cs" Inherits="FormularioRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <section class="content-header">
        <h1 style="text-align: center">REGISTRO DE ROLES</h1>
    </section>
    <asp:HiddenField runat="server" ID="hdnId" />
    <div class="row">
        <div class="col-md-6">
            <div class="box box-primary">
                <div class="box-body">
                    <div class="form-group">
                        <label>ROL</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtNombre" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="txtNombre"
                            ErrorMessage="Rellenar el campo de rol"
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
                        <label>DESCRIPCION</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtDescripcion" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="txtDescripcion"
                            ErrorMessage="Rellenar el campo de descripcion de permiso"
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

