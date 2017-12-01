<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="AbmUsuario.aspx.cs" Inherits="AbmUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="grvUsuario" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover table-responsive" DataSourceID="ObjectDataSource1" OnDataBound="grvUsuario_DataBound">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id"></asp:BoundField>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido"></asp:BoundField>
            <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario"></asp:BoundField>
            <asp:BoundField DataField="Contrasena" HeaderText="Contrasena" SortExpression="Contrasena"></asp:BoundField>
            <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo"></asp:BoundField>
            <asp:BoundField DataField="CI" HeaderText="CI" SortExpression="CI"></asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%#"~/ZBackend/FormularioUsuarios.aspx?ID=" + Eval("ID") %>' runat="server">Editar</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Eliminar" ID="btnEliminar" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="btnEliminar_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%#"~/ZBackend/FormularioUsuarios.aspx?ID=" + Eval("ID") %>' runat="server">Editar</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Eliminar" ID="btnEliminar2" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="btnEliminar_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%#"~/ZBackend/Default.aspx?ID=" + Eval("ID") %>' runat="server">VER CURSO</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="Seguridad.BLL.UsuarioBLL"></asp:ObjectDataSource>
</asp:Content>

