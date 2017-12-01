<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="VerCursos.aspx.cs" Inherits="ZBackend_VerCursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Repeater ID="rCursos" runat="server" DataSourceID="odsCursos">
        <ItemTemplate>
            <div style="float: left; margin-top: 90px; margin-left: 125px;">

                <%--<%# Eval("NombreCurso") %>--%>
                <asp:Image Width="150px" Height="180px" ImageUrl='<%#  "~/img/cursos/" + Eval("CursoSeleccionado.nombre")+".jpg" %>' runat="server" />
                <asp:HyperLink runat="server" NavigateUrl='<%# "~/ZBackend/DetalleCurso.aspx?ID=" + Eval("CursoSeleccionado.id")%>'><i class="fa fa-hand-o-right" style="color:#000000; margin-left:60px; font-size:20px;" aria-hidden="true"></i>Ver el Curso</asp:HyperLink>

            </div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:ObjectDataSource runat="server" ID="odsCursos" SelectMethod="SelectByIdCategoria" TypeName="CategoriaCursoBLL" OldValuesParameterFormatString="original_{0}">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="hdnCategoriaNombre" Name="id" Type="Int32"></asp:QueryStringParameter>
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

