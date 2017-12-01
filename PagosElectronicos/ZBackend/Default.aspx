<%@ Page Title="" Language="C#" MasterPageFile="~/ZBackend/Backend.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ZBackend_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Repeater runat="server" DataSourceID="ObjectDataSource1">
        <ItemTemplate>


            <asp:Image Width="150px" Height="180px" ImageUrl='<%#  "~/img/cursos/" + Eval("CursoSeleccionado.nombre")+".jpg" %>' runat="server" />
            <div style="margin-top:10px;">
                <%# Eval("Nombre")%>
            </div>


        </ItemTemplate>
    </asp:Repeater>




    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="UsuarioSelectById" TypeName="CursoBLL">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="id" Name="id" Type="Int32"></asp:QueryStringParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

