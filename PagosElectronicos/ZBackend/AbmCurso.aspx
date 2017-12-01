<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="AbmCurso.aspx.cs" Inherits="AbmCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:GridView ID="grvCurso" runat="server" AutoGenerateColumns="False" DataSourceID="odsCurso" CssClass="table table-bordered table-hover table-responsive" OnDataBound="grvCurso_DataBound">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id"></asp:BoundField>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre"></asp:BoundField>
            <asp:BoundField DataField="FechaInicio" HeaderText="FechaInicio" SortExpression="FechaInicio"></asp:BoundField>
            <asp:BoundField DataField="FechaFin" HeaderText="FechaFin" SortExpression="FechaFin"></asp:BoundField>
            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto"></asp:BoundField>
            <asp:BoundField DataField="Docente" HeaderText="Docente" SortExpression="Docente"></asp:BoundField>
            <asp:BoundField DataField="RegistroCertificado" HeaderText="RegistroCertificado" SortExpression="RegistroCertificado"></asp:BoundField>
            <asp:BoundField DataField="Modalidad" HeaderText="Modalidad" SortExpression="Modalidad"></asp:BoundField>
            <asp:BoundField DataField="Grado" HeaderText="Grado" SortExpression="Grado"></asp:BoundField>
            <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo"></asp:BoundField>
            <asp:BoundField DataField="RegistroGratis" HeaderText="RegistroGratis" SortExpression="RegistroGratis"></asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="btnEditar" NavigateUrl='<%#"~/ZBackend/FormularioCursos.aspx?ID=" + Eval("ID") %>' runat="server">Editar</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Eliminar" ID="btnEliminar" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="btnEliminar_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="btnEditar2" NavigateUrl='<%#"~/ZBackend/FormularioCursos.aspx?ID=" + Eval("ID") %>' runat="server">Editar</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton Text="Eliminar" ID="btnEliminar2" CommandArgument='<%# Eval("ID") %>' runat="server" OnClick="btnEliminar2_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource runat="server" ID="odsCurso" SelectMethod="SelectAll" TypeName="CursoBLL"></asp:ObjectDataSource>




</asp:Content>

