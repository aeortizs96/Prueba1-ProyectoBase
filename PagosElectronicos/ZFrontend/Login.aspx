<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="ZFrontend_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-language" content="es" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Pagos Electronicos</title>

    <%-- EstiloLogin --%>

    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/AdminLTE.css" rel="stylesheet" type="text/css" />
    <link href="../Content/estiloMejorarLogin.css" rel="stylesheet" />


    <%-- End EstiloLogin --%>

    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" />
    <link href="../Content/estiloFrontend.css" rel="stylesheet" />

    <link href="../css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" type="image/x-icon" href="../img/ESFERA_NUR1-VersionIco.ico" />

    <!-- Ionicons -->
    <link href="../css/ionicons.min.css" rel="stylesheet" type="text/css" />
    <link href="../css/AdminLTE.css" rel="stylesheet" type="text/css" />
    <link href="jAlert/jquery.alerts.css" rel="stylesheet" type="text/css" />

    <!-- DataTables -->
    <link href="css/datatables/dataTables.bootstrap.css" rel="stylesheet" />

    <style>
        html, body {
            min-height: 100%;
            padding: 0;
            margin: 0;
            font-family: 'Source Sans Pro', "Helvetica Neue", Helvetica, Arial, sans-serif;
        }

        iframe {
            display: block;
            overflow: auto;
            border: 0;
            margin: 0;
            padding: 0;
            margin: 0 auto;
        }

        .frame {
            height: 49px;
            margin: 0;
            padding: 0;
            border-bottom: 1px solid #ddd;
        }

            .frame a {
                color: #666;
            }

                .frame a:hover {
                    color: #222;
                }

            .frame .buttons a {
                height: 49px;
                line-height: 49px;
                display: inline-block;
                text-align: center;
                width: 50px;
                border-left: 1px solid #ddd;
            }

            .frame .brand {
                color: #444;
                font-size: 20px;
                line-height: 49px;
                display: inline-block;
                padding-left: 10px;
            }

                .frame .brand small {
                    font-size: 14px;
                }

        a, a:hover {
            text-decoration: none;
        }

        .container-fluid {
            padding: 0;
            margin: 0;
        }

        .text-muted {
            color: #999;
        }

        .ad {
            text-align: center;
            position: fixed;
            bottom: 0;
            left: 0;
            background: #222;
            background: rgba(0,0,0,0.8);
            width: 100%;
            color: #fff;
            display: none;
        }

        #close-ad {
            float: left;
            margin-left: 10px;
            margin-top: 10px;
            cursor: pointer;
        }
    </style>

</head>
<body class="skin-blue">
    <header class="header">
        <%-- INICIO DE CABECERA --%>

        <a href="PaginaDeInicioInvitado.aspx" class="logo">
            <img src="../img/fondoNurBlanco.png" id="imglogoblanco" runat="server" />
            Pagos Online</a>
        <nav class="navbar navbar-static-top" role="navigation">


            <div class="container-fluid">


                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="navbar-collapse">
                    <ul class="nav navbar-nav">
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">OFERTA ACADEMICA <span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <li><a href="VerCategoriasSinMatriculado.aspx">CATEGORIAS</a></li>
                                <li class="divider"></li>
                                <li><a href="#">VER LOS MAS POPULARES</a></li>
                                <li class="divider"></li>
                                <li><a href="#">VER LOS ULTIMO CURSOS OFERTADOS</a></li>
                                <li class="divider"></li>
                                <li><a href="#">VER TODOS LOS CURSOS</a></li>
                            </ul>
                        </li>
                        <li><a href="#">CONTACTENOS</a></li>

                    </ul>
                    <form class="navbar-form navbar-left" role="search">
                        <div class="form-group">
                            <input type="text" class="form-control" id="navbar-search-input" placeholder="Search">
                        </div>
                    </form>
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="FormularioRegistroUsuario.aspx">Registrate</a></li>

                        <li><a href="PaginaDeInicioInvitado.aspx"><i class="fa fa-hand-o-left" aria-hidden="true"></i>&nbsp;&nbsp;Volver &nbsp;&nbsp;&nbsp;&nbsp;</a></li>



                    </ul>
                </div>
                <!-- /.navbar-collapse -->
            </div>
            <!-- /.container-fluid -->
        </nav>

    </header>

    <%-- MENU IZQUIERDO --%>
    <div class="wrapper row-offcanvas row-offcanvas-left">

        <aside class="right-side">

            <section class="content">

                <video id="video-background" src="../video/video35anosmute.mp4" autoplay loop poster="../img/posterLogo.png"></video>


                <div class="form-box" id="login-box">
                    <div class="header" id="tituloHeader">
                        <asp:Label Text="Iniciar Sesion" runat="server" ID="lblInicioSesion" Style="font-weight: bold;" />
                        <img src="../img/logoNur%204.jpg" alt="Logo Nur" class="img-fluid" id="imgLogo" />

                    </div>
                    <form id="form1" runat="server">
                        <div class="body bg-gray" id="bloquePlomo">

                            <div class="form-group" id="parteUsuario" style="">
                                <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" placeholder="Usuario" autofocus="autofocus"></asp:TextBox>
                            </div>
                            <div class="form-group" id="parteContrasena">
                                <asp:TextBox runat="server" ID="txtContrasena" CssClass="form-control" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="MsgLabel" runat="server" Visible="false" Text="El Nombre de Usuario y/o Contraseña son invalidos" ForeColor="Red"></asp:Label>
                            </div>
                        </div>
                        <div class="footer">
                            <asp:Button ID="BtnLogin" runat="server" CssClass="btn btn-block" Text="Entrar" OnClick="BtnLogin_Click" />
                        </div>

                    </form>
                </div>



            </section>
        </aside>
    </div>
</body>

<script src="../js/jquery.min.js" type="text/javascript"></script>
<script src="../js/bootstrap.min.js" type="text/javascript"></script>
<script src="../js/jquery-ui.min.js" type="text/javascript"></script>
<script src="../js/AdminLTE/app.js" type="text/javascript"></script>
<script src="../jAlert/jquery.alerts.js" type="text/javascript"></script>
<script src="../js/jquery.ui.draggable.js" type="text/javascript"></script>

<script src="../js/plugins/datatables/jquery.dataTables.js"></script>
<script src="../js/plugins/datatables/dataTables.bootstrap.js"></script>

</html>
