<%@ Page Title="" Language="C#" MasterPageFile="~/ZFrontend/Frontend.master" AutoEventWireup="true" CodeFile="DetalleCursoSinMatriculado.aspx.cs" Inherits="ZFrontend_DetalleCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Repeater runat="server" DataSourceID="odsSeleccionUnCurso">
        <ItemTemplate>
            <asp:Image Width="300px" Height="320px" ImageUrl='<%#  "~/img/cursos/" + Eval("CursoSeleccionado.nombre")+".jpg" %>' runat="server" />

            <div style="margin-top: -280px; margin-left: 350px; color: aliceblue;">
                <div style="font-family: 'Fascinate Inline', cursive; font-size: 30px;">
                    <asp:Label><%# Eval("Nombre")%></asp:Label>
                </div>
                <div style="font-family: 'Fascinate Inline', cursive; font-size: 20px;">
                    <asp:Label><%# Eval("Direccion")%></asp:Label>
                </div>
                <div style="font-family: 'Fascinate Inline', cursive; font-size: 20px;">
                    <asp:Label><%# Eval("FechaInicio")%></asp:Label>
                </div>
                <div style="font-family: 'Fascinate Inline', cursive; font-size: 20px;">
                    <asp:Label><%# Eval("FechaFin")%></asp:Label>
                </div>
                <div style="color:black;">
                    <asp:Button runat="server" ID="btnRegistroCertificado" Text="Agregar" OnClick="btnRegistroCertificado_Click" />
                    <div style="font-family: 'Fascinate Inline', cursive; font-size: 20px;">
                        <asp:Label><%# Eval("RegistroCertificado")%></asp:Label>
                    </div>

                    <asp:Button runat="server" ID="btnRegistroGratis" Text="Agregar" OnClick="btnRegistroGratis_Click" />
                    <div style="font-family: 'Fascinate Inline', cursive; font-size: 20px;">
                        <asp:Label><%# Eval("RegistroGratis")%></asp:Label>

                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>

    <div style="margin-left: 350px;">
        <asp:Button ID="btnmatriculaSinRegistro" runat="server" CssClass="btn btn-primary " Width="200px" Text="Matricularme" OnClick="btnmatriculaSinRegistro_Click" />
    </div>


    <asp:ObjectDataSource runat="server" ID="odsSeleccionUnCurso" SelectMethod="SelectById" TypeName="CursoBLL">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="id" Name="id" Type="Int32"></asp:QueryStringParameter>
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

