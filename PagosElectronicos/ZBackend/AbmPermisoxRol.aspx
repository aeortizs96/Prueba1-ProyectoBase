<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="AbmPermisoxRol.aspx.cs" Inherits="ZBackend_AbmPermisoxRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
    <asp:GridView ID="grvPermisoRol" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover table-responsive" DataSourceID="ObjectDataSource1" OnDataBound="grvPermisoRol_DataBound">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id"></asp:BoundField>
            <asp:BoundField DataField="NombrePermiso" HeaderText="NombrePermiso" SortExpression="NombrePermiso"></asp:BoundField>
            <asp:BoundField DataField="NombreRol" HeaderText="NombreRol" SortExpression="NombreRol"></asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Eliminar" ID="btnEliminar" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="btnEliminar_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="Seguridad.BLL.PermisoRolBLL"></asp:ObjectDataSource>
</asp:Content>

