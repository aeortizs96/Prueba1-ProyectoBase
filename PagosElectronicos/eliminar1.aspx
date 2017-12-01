<%@ Page Language="C#" AutoEventWireup="true" CodeFile="eliminar1.aspx.cs" Inherits="eliminar1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <%--<script src="js/jquery-1.10.1.min.js" type="text/javascript"></script>--%>
    <script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
    <link href="animations.css" rel="stylesheet" />

</head>

<script>
    $(window).scroll(function () {
        $('#animatedElement').each(function () {
            var imagePos = $(this).offset().top;

            var topOfWindow = $(window).scrollTop();
            if (imagePos < topOfWindow + 400) {
                $(this).addClass("slideUp");
            }
        });
    });
</script>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <script>
        $('#animatedElement').click(function () {
            $(this).addClass("slideUp");
        });
    </script>
</body>
</html>
