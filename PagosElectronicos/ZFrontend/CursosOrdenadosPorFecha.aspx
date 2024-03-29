﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ZFrontend/Frontend.master" AutoEventWireup="true" CodeFile="CursosOrdenadosPorFecha.aspx.cs" Inherits="ZFrontend_CursosOrdenadosPorFecha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Repeater ID="rCursos" runat="server" DataSourceID="ObjectDataSource1">
        <ItemTemplate>
            <div style="float: left; margin-top: 90px; margin-left: 125px;">
                <%# Eval("FechaInicio") %>
                <asp:Image Width="150px" Height="180px" ImageUrl='<%#  "~/img/cursos/" + Eval("CursoSeleccionado.nombre")+".jpg" %>' runat="server" />
                <asp:HyperLink runat="server" NavigateUrl='<%# "~/ZFrontend/DetalleCursoSinMatriculado.aspx?ID=" + Eval("CursoSeleccionado.id")%>'><i class="fa fa-hand-o-right" style="color:#000000; margin-left:60px; font-size:20px;" aria-hidden="true"></i>Ver el Curso</asp:HyperLink>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SelectAllFecha" TypeName="CursoBLL"></asp:ObjectDataSource>
</asp:Content>

