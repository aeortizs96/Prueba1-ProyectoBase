<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="DetalleCurso.aspx.cs" Inherits="ZBackend_DetalleCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Repeater runat="server" DataSourceID="odsSeleccionUnCurso">
        <ItemTemplate>
            <asp:Image Width="200px" Height="200px" ImageUrl='<%#  "~/img/cursos/" + Eval("CursoSeleccionado.nombre")+".jpg" %>' runat="server" />
            <div style="margin-top:-200px; margin-left:250px;">
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
                <br />
                <asp:Label Text="Registros con Certificacion disponible" runat="server" />
                <div style="font-family: 'Fascinate Inline', cursive; font-size: 20px; margin-left: 300px; margin-top: -25px;">
                    <asp:Label ID="lblRegistroCertificado" runat="server"><%# Eval("RegistroCertificado")%></asp:Label>
                </div>
                <br />
                <br />
                <asp:Label Text="Registros con Gratis" runat="server" />
                <div style="font-family: 'Fascinate Inline', cursive; font-size: 20px; margin-left: 300px; margin-top: -25px;">
                    <asp:Label ID="lblRegistroGratis" runat="server"><%# Eval("RegistroGratis")%></asp:Label>
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>

    <div style="margin-top: -80px; margin-left: 600px;">
        <asp:TextBox runat="server" ID="txtRestarRegistroCertificado" />
        <asp:Button runat="server" ID="btnRegistroCertificado" Text="Agregar" OnClick="btnRegistroCertificado_Click" />
    </div>

    <div style="margin-top: 30px; margin-left: 600px;">
        <asp:TextBox runat="server" ID="txtRestarRegistroGratis" />
        <asp:Button runat="server" ID="btnRegistroGratis" Text="Agregar" OnClick="btnRegistroGratis_Click" />
    </div>


    <br />
    <br />



    <asp:Button ID="btnmatricula" runat="server" CssClass="btn btn-primary" Width="200px" Text="Matricularme" OnClick="btnmatricula_Click" />


    <asp:ObjectDataSource runat="server" ID="odsSeleccionUnCurso" SelectMethod="SelectById" TypeName="CursoBLL">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="id" Name="id" Type="Int32"></asp:QueryStringParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

