<%@ Page Title="" Language="C#" MasterPageFile="~/ZFrontend/Frontend.master" AutoEventWireup="true" CodeFile="VerCursosSinMatriculado.aspx.cs" Inherits="ZFrontend_VerCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <asp:Repeater ID="rCursos" runat="server" DataSourceID="odsCursos">
        <ItemTemplate>
            <div style="float: left; margin-top: 90px; margin-left: 125px;">
                <%--<%# Eval("NombreCurso") %>--%>
                <asp:Image Width="150px" Height="180px" ImageUrl='<%#  "~/img/cursos/" + Eval("CursoSeleccionado.nombre")+".jpg" %>' runat="server" />
                <div style="margin-top: 15px; margin-left: -20px;">
                    <asp:HyperLink runat="server" NavigateUrl='<%# "~/ZFrontend/DetalleCursoSinMatriculado.aspx?ID=" + Eval("CursoSeleccionado.id")%>'><i class="fa fa-hand-o-right" style="color:#000000; margin-left:60px; font-size:20px;" aria-hidden="true"></i>Ver el Curso</asp:HyperLink>
                </div>
                <div style="margin-top: 0px; margin-left: 20px; color:aliceblue;">
                    <%# Eval("NombreCurso") %>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:ObjectDataSource runat="server" ID="odsCursos" SelectMethod="SelectByIdCategoria" TypeName="CategoriaCursoBLL" OldValuesParameterFormatString="original_{0}">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="hdnCategoriaNombre" Name="id" Type="Int32"></asp:QueryStringParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

