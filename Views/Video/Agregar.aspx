<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Agregar</title>
</head>
<body>
    <h1>
     
   <form method="post" action="InsertarRegistro">
        <table>
            <tr>
                <td>Video Id</td>
                <td><input type="text" name="idVideo" /></td>
             </tr>
             <tr>
                <td>Titulo</td>
                <td><input type="text" name="titulo" /></td>
             </tr>
             <tr>
                <td>Reproducciones</td>
                <td><input type="text" name="reproducciones" /></td>
             </tr>
             <tr>
                <td>URL</td>
                <td><input type="text" name="URL" /></td>
             </tr>
             <tr>
                <td colspan="2"><input type="submit" value="Submit"/></td>
             </tr>
        </table>
    </form>

    </h1>
</body>
</html>
