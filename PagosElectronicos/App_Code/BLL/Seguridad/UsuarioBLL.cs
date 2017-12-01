using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seguridad.BLL
{
    public class UsuarioBLL
    {
        public UsuarioBLL() { }

        public static Usuario GetUsuarioByUserName(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentException("El nombre de usuario no puede ser nulo ni vacio");

            UsuarioDSTableAdapters.UsuarioSegTableAdapter adapter = new UsuarioDSTableAdapters.UsuarioSegTableAdapter();
            UsuarioDS.UsuarioSegDataTable table = adapter.GetUsuarioByUsername(username);

            Usuario user = null;
            if (table.Rows.Count == 1)
            {
                UsuarioDS.UsuarioSegRow row = table[0];
                user = new Usuario()
                {
                    Id = row.id,
                    Nombre = row.nombre,
                    Apellido = row.apellido,
                    NombreUsuario = row.nombreUsuario,
                    Contrasena = row.contrasena,
                    Correo = row.correo,
                    CI = row.cI,
                    Sexo = row.sexo,
                    rolId = row.idRol
                };


            }

            return user;
        }


        public static List<Usuario> SelectAll()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            UsuarioDSTableAdapters.TblUsuarioTableAdapter adapter = new UsuarioDSTableAdapters.TblUsuarioTableAdapter();
            UsuarioDS.TblUsuarioDataTable table = adapter.SelectAll();
            foreach (UsuarioDS.TblUsuarioRow row in table)
            {
                listaUsuarios.Add(rowToDTO(row));
            }
            return listaUsuarios;
        }


        public static Usuario SelectByLogin(string nombreUsuario, string hashedContrasena)
        {
            UsuarioDSTableAdapters.TblUsuarioTableAdapter adapter = new UsuarioDSTableAdapters.TblUsuarioTableAdapter();
            UsuarioDS.TblUsuarioDataTable table = adapter.SelectByLogin(nombreUsuario, hashedContrasena);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return rowToDTO(table[0]);
        }


        public static Usuario SelectById(int id)
        {
            UsuarioDSTableAdapters.TblUsuarioTableAdapter adapter = new UsuarioDSTableAdapters.TblUsuarioTableAdapter();
            UsuarioDS.TblUsuarioDataTable table = adapter.SelectById(id);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return rowToDTO(table[0]);
        }

        public static Usuario SelectById2(int id)
        {
            UsuarioDSTableAdapters.sp_Usuario_SelectById2TableAdapter adapter = new UsuarioDSTableAdapters.sp_Usuario_SelectById2TableAdapter();
            UsuarioDS.sp_Usuario_SelectById2DataTable table = adapter.Usuario2(id);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return rowToDTO2(table[0]);
        }

      
        public static void Insert(string nombre, string apellido, string nombreUsuario, string contrasena, string correo, string cI, string sexo, int rolId)
        {
            UsuarioDSTableAdapters.TblUsuarioTableAdapter adapter = new UsuarioDSTableAdapters.TblUsuarioTableAdapter();
            adapter.Insert(nombre, apellido, nombreUsuario, contrasena, correo, cI, sexo, rolId);
        }

        public static void Update(string nombre, string apellido, string nombreUsuario, string contrasena, string correo, string cI, string sexo, int rolId, int id)
        {
            UsuarioDSTableAdapters.TblUsuarioTableAdapter adapter = new UsuarioDSTableAdapters.TblUsuarioTableAdapter();
            adapter.Update(nombre, apellido, nombreUsuario, contrasena, correo, cI, sexo, rolId, id);
        }
        public static void Delete(int id)
        {
            UsuarioDSTableAdapters.TblUsuarioTableAdapter adapter = new UsuarioDSTableAdapters.TblUsuarioTableAdapter();
            adapter.Delete(id);
        }


        private static Usuario rowToDTO(UsuarioDS.TblUsuarioRow row)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.Id = row.id;
            objUsuario.Nombre = row.nombre;
            objUsuario.Apellido = row.apellido;
            objUsuario.NombreUsuario = row.nombreUsuario;
            objUsuario.Contrasena = row.contrasena;
            objUsuario.Correo = row.correo;
            objUsuario.CI = row.cI;
            objUsuario.Sexo = row.sexo;
            return objUsuario;

        }

        private static Usuario rowToDTO2(UsuarioDS.sp_Usuario_SelectById2Row row)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.Id = row.id;
            return objUsuario;
        }

    }
}