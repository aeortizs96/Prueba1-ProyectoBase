using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using Seguridad;
using Seguridad.BLL;

/// <summary>
/// Descripción breve de TextUtilities
/// </summary>
public class SeguridadUtils
{
    public SeguridadUtils()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static string Hash(string input)
    {
        using (SHA1Managed sha1 = new SHA1Managed())
        {
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder(hash.Length * 2);

            foreach (byte b in hash)
            {
                // can be "x2" if you want lowercase
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }


    //public static string Hash(string str)
    //{
    //    SHA1 sha1 = SHA1Managed.Create();
    //    ASCIIEncoding encoding = new ASCIIEncoding();
    //    byte[] stream = null;
    //    StringBuilder sb = new StringBuilder();
    //    stream = sha1.ComputeHash(encoding.GetBytes(str));
    //    for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
    //    return sb.ToString();
    //}

    public static Usuario IsUserValid(string nombreUsuario, string contrasena)
    {

        try
        {
            //VERIFICA si hay un usuario con ese nombreUsuario en la BD y si es asi pregunta si las contrasena 
            //tambien son iguales
            Usuario usr = UsuarioBLL.GetUsuarioByUserName(nombreUsuario);
            if (usr != null && usr.Contrasena == contrasena)
            {
                return usr;
            }
        }
        catch (Exception ex)
        {

        }

        return null;
    }

    public static void SetUserInSession(Usuario user)
    {
        HttpContext.Current.Session["usuario"] = user;
    }

    public static Usuario GetUserInSession()
    {
        //Usuario usr = null;
        //if (ThereAreUserInSession())
        //    usr = (Usuario)HttpContext.Current.Session["usuario"];
        //else
        //    usr = null;
        //return usr;

        return ThereAreUserInSession() ? (Usuario)HttpContext.Current.Session["usuario"] : null;
    }

    //QUE RETORNE VERDADERO POR L LA SESION SI ES DIFERENTE DE NULO
    public static bool ThereAreUserInSession()
    {
        return HttpContext.Current.Session["usuario"] != null;
    }

    // vuelve el valor de la sesion igual a nulo
    public static void Logout()
    {
        HttpContext.Current.Session["usuario"] = null;
    }

    public static bool UserInSessionHasPermission(string permissionKey)
    {
        Usuario usuario = SeguridadUtils.GetUserInSession();
        bool puedeIngresar = false;
        //try
        //{
        //    puedeIngresar = PermisoBLL.VerificarPermisoUsuario(usuario.UsuarioId, permissionKey);
        //}
        //catch (Exception ex)
        //{
        //    puedeIngresar = false;
        //}
        return puedeIngresar;
    }

}