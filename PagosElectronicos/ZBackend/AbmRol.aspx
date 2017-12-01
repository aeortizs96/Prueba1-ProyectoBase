<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="AbmRol.aspx.cs" Inherits="AbmRol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <asp:GridView ID="grvRol" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover table-responsive" DataSourceID="ObjectDataSource1" OnDataBound="grvRol_DataBound">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id"></asp:BoundField>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion"></asp:BoundField>

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%#"~/ZBackend/FormularioRols.aspx?ID=" + Eval("ID") %>' runat="server">Editar</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Eliminar" ID="btnEliminar" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="btnEliminar_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%#"~/ZBackend/FormularioRols.aspx?ID=" + Eval("ID") %>' runat="server">Editar</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Eliminar" ID="btnEliminar2" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="btnEliminar_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAll" TypeName="Seguridad.BLL.RolBLL"></asp:ObjectDataSource>
</asp:Content>

